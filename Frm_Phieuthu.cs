using HandlebarsDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAOVO_QLTC
{
    public partial class Frm_Phieuthu : Form
    {
        Frm_Quanlinguonthu currentFrmQuanlinguonthu;
        public Frm_Phieuthu(Frm_Quanlinguonthu frm_Quanlinguonthu)
        {
            InitializeComponent();
            currentFrmQuanlinguonthu = frm_Quanlinguonthu;
            LoadCbbLoaiNguoiDung();
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            ComboBoxItem cbbManguoinopSelected = (ComboBoxItem)cbb_manguoinop.SelectedItem;
            ComboBoxItem cbbLoainguoinopSelected = (ComboBoxItem)cbb_loainguoinop.SelectedItem;

            if (string.IsNullOrWhiteSpace(txt_sotienbangchu.Text))
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
            string path = System.IO.Path.Combine(Environment.CurrentDirectory) + "\\Phieuthuthuong\\phieuthu.html";
            string htmlTemplate = File.ReadAllText(path);
            var template = Handlebars.Compile(htmlTemplate);
            var data = new
            {
                loainguoinop = cbbLoainguoinopSelected.Text,
                maphieuthu = txt_mathu.Text,
                manguoinop = cbbManguoinopSelected.Value,
                hovaten = lbl_ten.Text,
                noidungthu = txt_noidungthu.Text,
                sotien = txt_sotien.Text,
                sotienvietbangchu = txt_sotienbangchu.Text,
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
                var OutputPath = folderDlg.SelectedPath + "\\Phiếu thu " + cbbManguoinopSelected.Value + ".pdf";
                PDF.SaveAs(OutputPath);
                MessageBox.Show("Đã in xong phiếu thu học phí", "Thông báo");
                ckb_rule.Checked = false;
                insertNguonThu();
            }
        }

        private void LoadCbbMaNguoiDung(string loainguoinop)
        {
            cbb_manguoinop.Items.Clear();
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            if(loainguoinop.Equals("gv"))
            {
                command.CommandText = "Select * from GIAOVIEN";

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = reader["tengv"] + " - " + reader["magv"];
                    item.Value = (string)reader["magv"];
                    item.Name = (string)reader["tengv"];
                    cbb_manguoinop.Items.Add(item);
                }

            }

            if (loainguoinop.Equals("hs"))
            {
                command.CommandText = "Select * from HOCSINH";

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = reader["mahs"] + " - " + reader["hoten"];
                    item.Value = (string)reader["mahs"];
                    item.Text = (string)reader["hoten"];
                    cbb_manguoinop.Items.Add(item);
                }

            }
            cbb_manguoinop.SelectedIndex = 0;
            cbb_manguoinop.Refresh();
        }

        private void LoadCbbLoaiNguoiDung()
        {

                ComboBoxItem itemNhanVien = new ComboBoxItem();
                itemNhanVien.Text = "Giáo viên";
                itemNhanVien.Value = "gv";
                cbb_loainguoinop.Items.Add(itemNhanVien);

                ComboBoxItem itemHocSinh = new ComboBoxItem();
                itemHocSinh.Text = "Học Sinh";
                itemHocSinh.Value = "hs";
                cbb_loainguoinop.Items.Add(itemHocSinh);
        
                cbb_loainguoinop.SelectedIndex = 0;
        }

        private void cbb_loainguoinop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbbItemSelected = (ComboBoxItem)cbb_loainguoinop.SelectedItem;
            LoadCbbMaNguoiDung(cbbItemSelected.Value);
        }

        private void cbb_manguoinop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbbItemSelected = (ComboBoxItem)cbb_manguoinop.SelectedItem;
            lbl_ten.Text = cbbItemSelected.Name;
        }

        private void insertNguonThu()
        {
            string maphieuthuinput = txt_mathu.Text;
            string sotienthuinput = txt_sotien.Text;
            string sotienchuinput = txt_sotienbangchu.Text;
            string lidothuinput = txt_noidungthu.Text;
            ComboBoxItem cbbManguoinopSelected = (ComboBoxItem)cbb_manguoinop.SelectedItem;
            ComboBoxItem cbbLoainguoinopSelected = (ComboBoxItem)cbb_loainguoinop.SelectedItem;

            if (string.IsNullOrWhiteSpace(maphieuthuinput)  || string.IsNullOrWhiteSpace(sotienthuinput) || string.IsNullOrWhiteSpace(sotienchuinput) || string.IsNullOrWhiteSpace(lidothuinput))
            {
                MessageBox.Show("Bạn không thể để trống bất kỳ ô dữ liệu nào", "Lỗi");
                return;
            }
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO NGUONTHU VALUES (@mathu,@loainguoinop,@manguoinop,@lidothu,@sotienthu,GETDATE(),@nguoithu)";

            SqlParameter paramMaThu = new SqlParameter();
            paramMaThu.ParameterName = "@mathu";
            paramMaThu.Value = maphieuthuinput;
            command.Parameters.Add(paramMaThu);

            SqlParameter paramLoainguoinop = new SqlParameter();
            paramLoainguoinop.ParameterName = "@loainguoinop";
            paramLoainguoinop.Value = cbbLoainguoinopSelected.Value;
            command.Parameters.Add(paramLoainguoinop);

            SqlParameter paramManguoinop = new SqlParameter();
            paramManguoinop.ParameterName = "@manguoinop";
            paramManguoinop.Value = cbbManguoinopSelected.Value;
            command.Parameters.Add(paramManguoinop);

            SqlParameter paramLydothu = new SqlParameter();
            paramLydothu.ParameterName = "@lidothu";
            paramLydothu.Value = lidothuinput;
            command.Parameters.Add(paramLydothu);

            SqlParameter paramSotienthu = new SqlParameter();
            paramSotienthu.ParameterName = "@sotienthu";
            paramSotienthu.Value = sotienthuinput;
            command.Parameters.Add(paramSotienthu);

            SqlParameter paramNguoithu = new SqlParameter();
            paramNguoithu.ParameterName = "@nguoithu";
            paramNguoithu.Value = Frm_dangnhap.manhanvien;
            command.Parameters.Add(paramNguoithu);


            int returnVal = command.ExecuteNonQuery();
            
        }
    }
}
