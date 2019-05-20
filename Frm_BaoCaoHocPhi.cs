using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAOVO_QLTC
{
    public partial class Frm_BaoCaoHocPhi : Form
    {
        public Frm_BaoCaoHocPhi()
        {
            InitializeComponent();
        }

        private void Frm_BaoCaoHocPhi_Load(object sender, EventArgs e)
        {
            Reprot_BaoCaoHocPhi rpt = new Reprot_BaoCaoHocPhi();
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlDataAdapter dataAdapter;

            DataSetTienHocPhi ds = new DataSetTienHocPhi();
            dataAdapter = new SqlDataAdapter("Select hp.mathu, hp.mahs, hs.hoten, hs.ngaysinh, hs.nienkhoa, hs.lop, hp.maloaihocphi, hp.mamiengiam, CASE WHEN hp.dathu IS NOT NULL THEN 'Đã thu' ELSE '' END AS dathu  from THUHOCPHI hp JOIN HOCSINH hs ON hs.mahs = hp.mahs", conn);
            dataAdapter.Fill(ds.DataTableHocPhi);
            DataTable dataTable = ds.DataTableHocPhi;

            foreach (DataRow row in dataTable.Rows)
            {
                {
                    string rowMaLoaiHocPhi = row["maloaihocphi"].ToString();
                    string rowMaMienGiam = row["mamiengiam"].ToString();
                    double totalTutionFee = CalTotalTutionFee(rowMaLoaiHocPhi);
                    double totalTutionOff = 0;
                    if (!string.IsNullOrEmpty(rowMaMienGiam))
                    {
                        totalTutionOff = CalTotalTutionFeeOff(rowMaMienGiam);
                    }
                    double haveToPayTution = totalTutionFee - (totalTutionFee * totalTutionOff);
                    row["tienhocphi"] = totalTutionFee.ToString("N0", CultureInfo.InvariantCulture);
                    if(totalTutionOff != 0)
                    {
                        row["tienmiengiam"] = (totalTutionFee * totalTutionOff).ToString("N0", CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        row["tienmiengiam"] = "";
                    }

                    row["tongtien"] = haveToPayTution.ToString("N0", CultureInfo.InvariantCulture);
                }
            }

            rpt.SetDataSource(dataTable);
            crv_hocphi.ReportSource = rpt;
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

        private void CloseConnection(SqlConnection conn)
        {
            // Đóng kết nối.
            conn.Close();
            // Hủy đối tượng, giải phóng tài nguyên.
            conn.Dispose();
        }
    }
}
