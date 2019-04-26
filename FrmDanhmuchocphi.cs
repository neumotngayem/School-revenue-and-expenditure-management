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
    public partial class FrmDanhmuchocphi : Form
    {
        private string lastChangeMaLoaiHocPhi;

        public FrmDanhmuchocphi()
        {
            InitializeComponent();
            LoadGridData();
        }

        private void LoadGridData()
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from DANHMUCHOCPHI", conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataAdapter.Dispose();
            dgvDMhocphi.DataSource = dataTable;           
        }

        private void btntaomoihp_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            string maloaihocphiInput = txtmaloaihp.Text;
            string tenloaihocphiInput = txttenhp.Text;
            string namhocInput = txtnamhoc.Text;
            string tongtienInput = txttongtien.Text;

            if (string.IsNullOrWhiteSpace(maloaihocphiInput) || string.IsNullOrWhiteSpace(tenloaihocphiInput) || string.IsNullOrWhiteSpace(namhocInput) || string.IsNullOrWhiteSpace(tongtienInput))
            {
                MessageBox.Show("Bạn không thể để trống bất kỳ ô dữ liệu nào", "Lỗi");
                return;
            }
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO DANHMUCHOCPHI (maloaihocphi,tenloaihocphi,namhoc,tienhoc) VALUES (@maloaihocphi,@tenloaihocphi,@namhoc,@tongtien)";


            SqlParameter parammaloaihocphi = new SqlParameter();
            parammaloaihocphi.ParameterName = "@maloaihocphi";
            parammaloaihocphi.Value = maloaihocphiInput;
            command.Parameters.Add(parammaloaihocphi);

            SqlParameter paramtenloaihocphi = new SqlParameter();
            paramtenloaihocphi.ParameterName = "@tenloaihocphi";
            paramtenloaihocphi.Value = tenloaihocphiInput;
            command.Parameters.Add(paramtenloaihocphi);

            SqlParameter paramnamhoc = new SqlParameter();
            paramnamhoc.ParameterName = "@namhoc";
            paramnamhoc.Value = namhocInput;
            command.Parameters.Add(paramnamhoc);


            SqlParameter paramtongtien = new SqlParameter();
            paramtongtien.ParameterName = "@tongtien";
            paramtongtien.Value = tongtienInput;
            command.Parameters.Add(paramtongtien);

            int returnVal = command.ExecuteNonQuery();
            if (returnVal == 1)
            {
                MessageBox.Show("Đã thêm loai hoc phi");
                LoadGridData();
                dgvDMhocphi.Refresh();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi");
            }
        }

        private void dgvDMhocphi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDMhocphi.Rows.Count != 0 && dgvDMhocphi.Rows != null)
            {
                txtmaloaihp.Text = dgvDMhocphi[0, dgvDMhocphi.CurrentRow.Index].Value.ToString();
                this.lastChangeMaLoaiHocPhi = txtmaloaihp.Text;
                txttenhp.Text = dgvDMhocphi[1, dgvDMhocphi.CurrentRow.Index].Value.ToString();
                txtnamhoc.Text = dgvDMhocphi[3, dgvDMhocphi.CurrentRow.Index].Value.ToString();
                txttongtien.Text = dgvDMhocphi[2, dgvDMhocphi.CurrentRow.Index].Value.ToString();
            }
        }

        private void btnsuahp_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Bạn có thực sự muốn thay đổi loại học phí này không ?", "Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmDelete == DialogResult.Yes)
            {
                if (!lastChangeMaLoaiHocPhi.Equals(txtmaloaihp.Text))
                {
                    MessageBox.Show("Mã loại học phí không thể thay đổi");
                    return;
                }

                SqlConnection conn = DBUtils.getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "UPDATE DANHMUCHOCPHI SET tenloaihocphi = @Tenloaihocphi, tienhoc = @Tienhoc, namhoc = @Namhoc  WHERE maloaihocphi = @Maloaihocphi";

                SqlParameter paramMaLoaiHocPhi = new SqlParameter();
                paramMaLoaiHocPhi.ParameterName = "@Maloaihocphi";
                paramMaLoaiHocPhi.Value = lastChangeMaLoaiHocPhi;
                command.Parameters.Add(paramMaLoaiHocPhi);

                SqlParameter paramLoaiHocPhi = new SqlParameter();
                paramLoaiHocPhi.ParameterName = "@Tenloaihocphi";
                paramLoaiHocPhi.Value = txttenhp.Text;
                command.Parameters.Add(paramLoaiHocPhi);

                SqlParameter paramTienhoc = new SqlParameter();
                paramTienhoc.ParameterName = "@Tienhoc";
                paramTienhoc.Value = txttongtien.Text;
                command.Parameters.Add(paramTienhoc);


                SqlParameter paramNamhoc = new SqlParameter();
                paramNamhoc.ParameterName = "@Namhoc";
                paramNamhoc.Value = txtnamhoc.Text;
                command.Parameters.Add(paramNamhoc);

                command.ExecuteNonQuery();
                CloseConnection(conn);
                LoadGridData();
                dgvDMhocphi.Refresh();
            }
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
