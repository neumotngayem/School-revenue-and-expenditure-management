using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAOVO_QLTC
{
    public partial class Frm_taotaikhoan : Form
    {
        public Frm_taotaikhoan()
        {
            InitializeComponent();
            LoadGridAccountData();
        }

        private void LoadGridAccountData()
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from NGUOIDUNG", conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataAdapter.Dispose();
            CloseConnection(conn);
            grdAccount.DataSource = dataTable;
        }

        private void BtnCreateClickEventHandler(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
        
            string usernameInput = txtUsername.Text;
            string passwordInput = GetMd5Hash(md5Hash, txtPassword.Text);
            string repasswordInput = GetMd5Hash(md5Hash, txtRePassword.Text);
            string staffIdInput = txtStaffID.Text;

            if (string.IsNullOrWhiteSpace(usernameInput) || string.IsNullOrWhiteSpace(passwordInput) || string.IsNullOrWhiteSpace(repasswordInput) || string.IsNullOrWhiteSpace(staffIdInput)) 
            {
                MessageBox.Show("Bạn không thể để trống bất kỳ ô dữ liệu nào", "Lỗi");
                return;
            }

            if (IsDuplicateUsername(usernameInput))
            {
                MessageBox.Show("Tên đăng nhập đã có trong hệ thống", "Lỗi");
                return;
            }

            if(!IsRePasswordMatch(passwordInput, repasswordInput))
            {
                MessageBox.Show("Mật khẩu không trùng nhau", "Lỗi");
                return;
            }

            if (!IsStaffIdExist(staffIdInput))
            {
                MessageBox.Show("Nhân viên không tồn tại", "Lỗi");
                return;
            }

            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO NGUOIDUNG (username, password, manhanvien, quyenid) VALUES(@Username, @Password, @Manhanvien, @QuyenID)";

            SqlParameter paramUsername = new SqlParameter();
            paramUsername.ParameterName = "@Username";
            paramUsername.Value = usernameInput;
            command.Parameters.Add(paramUsername);

            SqlParameter paramPassword = new SqlParameter();
            paramPassword.ParameterName = "@Password";
            paramPassword.Value = passwordInput;
            command.Parameters.Add(paramPassword);

            SqlParameter paramStaffID = new SqlParameter();
            paramStaffID.ParameterName = "@Manhanvien";
            paramStaffID.Value = staffIdInput;
            command.Parameters.Add(paramStaffID);

            SqlParameter paramRoleID = new SqlParameter();
            paramRoleID.ParameterName = "@QuyenID";
            paramRoleID.Value = "KT";
            command.Parameters.Add(paramRoleID);
            int returnVal = command.ExecuteNonQuery();
            if(returnVal == 1)
            {
                MessageBox.Show("Đã thêm người dùng");
                LoadGridAccountData();
                grdAccount.Refresh();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi");
            }
        }
        private string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private bool IsDuplicateUsername(string usernameInput)
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "Select 1 from NGUOIDUNG WHERE username = @Username";

            SqlParameter paramUsername = new SqlParameter();
            paramUsername.ParameterName = "@Username";
            paramUsername.Value = usernameInput;
            command.Parameters.Add(paramUsername);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                CloseConnection(conn);
                return true;
            }
            CloseConnection(conn);
            return false;
        }


        private bool IsRePasswordMatch(string passwordInput, string repasswordInput)
        {
            return passwordInput.Equals(repasswordInput, StringComparison.Ordinal);
        }

        private bool IsStaffIdExist(string staffIdInput)
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "Select 1 from NHANVIEN WHERE manhanvien = @StaffId";

            SqlParameter paramUsername = new SqlParameter();
            paramUsername.ParameterName = "@StaffId";
            paramUsername.Value = staffIdInput;
            command.Parameters.Add(paramUsername);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                CloseConnection(conn);
                return true;
            }
            CloseConnection(conn);
            return false;
        }
        private void CloseConnection(SqlConnection conn)
        {
            // Đóng kết nối.
            conn.Close();
            // Hủy đối tượng, giải phóng tài nguyên.
            conn.Dispose();
        }

        private void ShowPasswordChangeEventHandler(object sender, EventArgs e)
        {
            if (ckbShowPwd.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
