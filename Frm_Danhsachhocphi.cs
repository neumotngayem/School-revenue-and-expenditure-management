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
    public partial class Frm_Danhsachhocphi : Form
    {
        public static string mahsSelected;
        public Frm_Danhsachhocphi()
        {
            InitializeComponent();
            LoadGridData();
        }

        private void LoadGridData()
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select hp.mathu, hp.mahs, hs.hoten, hs.ngaysinh, hs.nienkhoa, hs.lop, hp.maloaihocphi, hp.mamiengiam, '' as tongtien  from THUHOCPHI hp JOIN HOCSINH hs ON hs.mahs = hp.mahs", conn);
            DataTable dataTable = new DataTable();
            
            dataAdapter.Fill(dataTable);
            dataAdapter.Dispose();

            foreach (DataRow row in dataTable.Rows)
            {
                {
                   string rowMaLoaiHocPhi = row["maloaihocphi"].ToString();
                   string rowMaMienGiam = row["mamiengiam"].ToString();
                    double totalTutionFee = calTotalTutionFee(rowMaLoaiHocPhi);
                    double totalTutionOff = calTotalTutionFeeOff(rowMaMienGiam);
                    double haveToPayTution = totalTutionFee - (totalTutionFee * totalTutionOff);

                    row["tongtien"] = haveToPayTution.ToString("N0", CultureInfo.InvariantCulture);
                }
            }

            grd_dshp.DataSource = dataTable;
        }

        private double calTotalTutionFee(string maloaiphi)
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT SUM(tienhoc) AS tongtienhoc FROM DANHMUCHOCPHI WHERE maloaihocphi IN("+maloaiphi+")";

            double tongtienhoc = 0;  

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                tongtienhoc = (double) reader["tongtienhoc"];
            }
            CloseConnection(conn);
            return tongtienhoc;
        }

        private double calTotalTutionFeeOff(string maloaimiengiam)
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
