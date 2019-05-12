using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HandlebarsDotNet;
using IronPdf;

namespace DAOVO_QLTC
{
    public partial class Frm_Phieuthuhocphi : Form
    {
        private readonly Frm_Danhsachhocphi currentFrmDsHocPhi;
        private string maphieuthuSelected;
        private string khoanthu = "";
        private string miengiam = "";
        private double tongtienNum;

        public Frm_Phieuthuhocphi(Frm_Danhsachhocphi frm_Danhsachhocphi)
        {
            InitializeComponent();
            this.maphieuthuSelected = Frm_Danhsachhocphi.maphieuthuSelected;
            currentFrmDsHocPhi = frm_Danhsachhocphi;
            LoadGridData();
        }

        private void LoadGridData()
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "Select hp.mathu, hp.mahs, hs.hoten, hs.ngaysinh, hs.nienkhoa, hs.lop, hp.maloaihocphi, hp.mamiengiam  from THUHOCPHI hp JOIN HOCSINH hs ON hs.mahs = hp.mahs WHERE hp.mathu = @Mathu";

            SqlParameter paramMathu = new SqlParameter
            {
                ParameterName = "@Mathu",
                Value = maphieuthuSelected
            };
            command.Parameters.Add(paramMathu);

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            lbl_mahs.Text = (string)reader["mahs"];
            lbl_ten.Text = (string)reader["hoten"];
            lbl_ngaysinh.Text = (string)reader["ngaysinh"];
            lbl_lop.Text = (string)reader["lop"];
            lbl_nienkhoa.Text = (string)reader["nienkhoa"];
            lbl_mathu.Text = reader["mathu"].ToString();


            string maloaihocphi = (string)reader["maloaihocphi"];
            string maloaimiengiam = (string)reader["mamiengiam"];

            double totalTutionFee = CalTotalTutionFee(maloaihocphi);
            double totalTutionOff = 0;
            if (!string.IsNullOrEmpty(maloaimiengiam))
            {
                totalTutionOff = CalTotalTutionFeeOff(maloaimiengiam);
                this.miengiam = (AggTutionFeeOffName(maloaimiengiam));
            }
            double haveToPayTution = totalTutionFee - (totalTutionFee * totalTutionOff);
            tongtienNum = haveToPayTution;
            lbl_tongtien.Text = haveToPayTution.ToString("N0", CultureInfo.InvariantCulture);

            this.khoanthu = AggTutionFeeName(maloaihocphi);
            tbx_noidungthu.AppendText(this.khoanthu);
            tbx_noidungthu.AppendText(Environment.NewLine);
            tbx_noidungthu.AppendText(miengiam);  
        }

        private double CalTotalTutionFee(string maloaiphi)
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT SUM(tienhoc) AS tongtienhoc FROM DANHMUCHOCPHI WHERE maloaihocphi IN(" + maloaiphi + ")";

            double tongtienhoc = 0;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                tongtienhoc = (double)reader["tongtienhoc"];
            }
            CloseConnection(conn);
            return tongtienhoc;
        }

        private double CalTotalTutionFeeOff(string maloaimiengiam)
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT SUM(mucmiengiam) AS tongmiengiam FROM DANHMUCMIENGIAM WHERE mamiengiam IN(" + maloaimiengiam + ")";

            double tongmiengiam = 0;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                tongmiengiam = (double)reader["tongmiengiam"];
            }
            CloseConnection(conn);
            return tongmiengiam;
        }

        private string AggTutionFeeName(string maloaihocphi)
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT tenloaihocphi FROM DANHMUCHOCPHI WHERE maloaihocphi IN(" + maloaihocphi + ")";
            string strAggTution = "";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                strAggTution += reader["tenloaihocphi"] + ", ";
            }
            strAggTution = strAggTution.TrimEnd();
            strAggTution = "Loại thu: " + strAggTution.Substring(0, strAggTution.Length - 1);
            CloseConnection(conn);
            return strAggTution;
        }

        private string AggTutionFeeOffName(string maloaimiengiam)
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT tenmiengiam FROM DANHMUCMIENGIAM WHERE mamiengiam IN(" + maloaimiengiam + ")";

            string strAggTutionOff = "";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                strAggTutionOff += reader["tenmiengiam"] + ", ";
            }
            strAggTutionOff = strAggTutionOff.TrimEnd();
            strAggTutionOff = "Miễn giảm: " + strAggTutionOff.Substring(0, strAggTutionOff.Length - 1);
            CloseConnection(conn);
            return strAggTutionOff;
        }

        private void CloseConnection(SqlConnection conn)
        {
            // Đóng kết nối.
            conn.Close();
            // Hủy đối tượng, giải phóng tài nguyên.
            conn.Dispose();
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_vietbangchu.Text))
            {
                MessageBox.Show("Bạn phải nhập số tiền bằng chữ", "Lỗi");
                return;
            }
            if (!ckb_rule.Checked)
            {
                MessageBox.Show("Bạn phải check vào điều khoản", "Lỗi");
                return;
            }
            DateTime dateTime = DateTime.Now;
            string path = System.IO.Path.Combine(Environment.CurrentDirectory) + "\\Phieuthuhocphi\\phieuthuhocphi.html";
            string htmlTemplate = File.ReadAllText(path);
            var template = Handlebars.Compile(htmlTemplate);
            var data = new
            {
                maphieuthu = lbl_mathu.Text,
                mahs = lbl_mahs.Text,
                hovaten = lbl_ten.Text,
                ngaysinh = lbl_ngaysinh.Text,
                lop = lbl_lop.Text,
                nienkhoa = lbl_nienkhoa.Text,
                khoanthu = this.khoanthu,
                miengiam =  this.miengiam,
                sotien = lbl_tongtien.Text,
                sotienvietbangchu = tbx_vietbangchu.Text,
                ngay = dateTime.Day,
                thang = dateTime.Month,
                nam = dateTime.Year
            };
            var result = template(data);
            var Renderer = new IronPdf.HtmlToPdf();
            var PDF = Renderer.RenderHtmlAsPdf(result);
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult diaresult = folderDlg.ShowDialog();
            if (diaresult == DialogResult.OK)
            {
                var OutputPath = folderDlg.SelectedPath+"\\Phiếu thu học phí " +lbl_mahs.Text+".pdf";
                PDF.SaveAs(OutputPath);
                MessageBox.Show("Đã in xong phiếu thu học phí", "Thông báo");
                ckb_rule.Checked = false;
                this.updatePhieuThu();
            }
        }

        private void updatePhieuThu()
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE THUHOCPHI SET  dathu = @Dathu, ngaythu = GETDATE(), nguoithu = @Nguoithu WHERE mathu = @Mathu";

            SqlParameter paramDathu = new SqlParameter
            {
                ParameterName = "@Dathu",
                Value = tongtienNum
            };
            command.Parameters.Add(paramDathu);

            SqlParameter paramNguoithu = new SqlParameter
            {
                ParameterName = "@Nguoithu",
                Value = Frm_dangnhap.manhanvien
            };
            command.Parameters.Add(paramNguoithu);

            SqlParameter paramMathu = new SqlParameter
            {
                ParameterName = "@Mathu",
                Value = lbl_mathu.Text
            };
            command.Parameters.Add(paramMathu);

            command.ExecuteNonQuery();
            currentFrmDsHocPhi.LoadGridData("");
        }
    }
}
