using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAOVO_QLTC
{
    public partial class Frm_Quanlinguonchi : Form
    {
        public Frm_Quanlinguonchi()
        {
            InitializeComponent();
            LoadCbbTeacherList();
            LoadGridnguonchi();        }

        private void LoadCbbTeacherList()
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "Select * from GIAOVIEN";

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = reader["magv"] + " - " + reader["tengv"];
                item.Value = reader["magv"];
                cbbmagv.Items.Add(item);
            }
            cbbmagv.SelectedIndex = 0;
        }

        private void LoadGridnguonchi()
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from NGUONCHI", conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataAdapter.Dispose();
            CloseConnection(conn);
            dgvnguonchi.DataSource = dataTable;
        }
        private void CloseConnection(SqlConnection conn)
        {
            // Đóng kết nối.
            conn.Close();
            // Hủy đối tượng, giải phóng tài nguyên.
            conn.Dispose();
        }
        private void btnxuatphieuchi_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            string maphieuchiinput = txtmaphieuchi.Text;
            string sotienchiinput = txtsotienchi.Text;
            string lidochiinput = txtsotienchi.Text;
            string magvInput = (cbbmagv.SelectedItem as ComboBoxItem).Value.ToString();

            if (string.IsNullOrWhiteSpace(maphieuchiinput) || string.IsNullOrWhiteSpace(sotienchiinput) || string.IsNullOrWhiteSpace(lidochiinput) || string.IsNullOrWhiteSpace(magvInput))
            {
                MessageBox.Show("Bạn không thể để trống bất kỳ ô dữ liệu nào", "Lỗi");
                return;
            }
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO NGUONCHI (machi,magv,lidochi,sotienchi) VALUES (@machi,@magv,@lidochi,@sotienchi)";

            SqlParameter parammaphieuchi = new SqlParameter();
            parammaphieuchi.ParameterName = "@machi";
            parammaphieuchi.Value = maphieuchiinput;
            command.Parameters.Add(parammaphieuchi);

            SqlParameter paramlidochi = new SqlParameter();
            paramlidochi.ParameterName = "@lidochi";
            paramlidochi.Value = lidochiinput;
            command.Parameters.Add(paramlidochi);

            SqlParameter paramsotienchi = new SqlParameter();
            paramsotienchi.ParameterName = "@sotienchi";
            paramsotienchi.Value = sotienchiinput;
            command.Parameters.Add(paramsotienchi);

            SqlParameter parammagv = new SqlParameter();
            parammagv.ParameterName = "@magv";
            parammagv.Value = magvInput;
            command.Parameters.Add(parammagv);


            int returnVal = command.ExecuteNonQuery();
            if (returnVal == 1)
            {

                LoadGridnguonchi();
                dgvnguonchi.Refresh();
                
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi");
            }

        }
    }
}
