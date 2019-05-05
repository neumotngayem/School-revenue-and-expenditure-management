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
    public partial class Frm_doimatkhau : Form
    {
        public Frm_doimatkhau()
        {
            InitializeComponent();
        }

        private void BtnChangePwdClickEventHandler(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            string usernameInput = txt_taikhoan.Text;
            string oldpassInput = GetMd5Hash(md5Hash, txt_oldpass.Text);
            string newpassInput = GetMd5Hash(md5Hash, txt_newpass.Text);
            string renewpassInput = GetMd5Hash(md5Hash, txt_renewpass.Text);

            if (string.IsNullOrWhiteSpace(usernameInput) || string.IsNullOrWhiteSpace(oldpassInput) || string.IsNullOrWhiteSpace(newpassInput) || string.IsNullOrWhiteSpace(renewpassInput))
            {
                MessageBox.Show("Bạn không thể để trống bất kỳ ô dữ liệu nào", "Lỗi");
                return;
            }


            if (!IsAccountCorrect(usernameInput, oldpassInput))
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu của bạn không chính xác", "Lỗi");
                return;
            }

            if (!IsRePasswordMatch(newpassInput, renewpassInput))
            {
                MessageBox.Show("Mật khẩu mới không trùng nhau", "Lỗi");
                return;
            }

            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE NGUOIDUNG SET  password = @Password WHERE username = @Username";

            SqlParameter paramUsername = new SqlParameter
            {
                ParameterName = "@Username",
                Value = usernameInput
            };
            command.Parameters.Add(paramUsername);

            SqlParameter paramPassword = new SqlParameter
            {
                ParameterName = "@Password",
                Value = newpassInput
            };
            command.Parameters.Add(paramPassword);

            int returnVal = command.ExecuteNonQuery();
            if (returnVal == 1)
            {
                MessageBox.Show("Mật khẩu cho tài khoản: "+usernameInput+" đã được cập nhật");
                txt_taikhoan.Text = "";
                txt_oldpass.Text = "";
                txt_newpass.Text = "";
                txt_renewpass.Text = "";
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi");
            }
        }

        private bool IsAccountCorrect(string username, string password)
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "Select 1 from NGUOIDUNG WHERE username = @Username AND password = @Password";

            SqlParameter paramUsername = new SqlParameter
            {
                ParameterName = "@Username",
                Value = username
            };
            command.Parameters.Add(paramUsername);

            SqlParameter paramPassword = new SqlParameter
            {
                ParameterName = "@Password",
                Value = password
            };
            command.Parameters.Add(paramPassword);

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

        private bool IsRePasswordMatch(string passwordInput, string repasswordInput)
        {
            return passwordInput.Equals(repasswordInput, StringComparison.Ordinal);
        }

        private void BtnCloseClickEventHandler(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPasswordOldChangeEventHandler(object sender, EventArgs e)
        {
            if (ckbShowPwdOld.Checked)
            {
                txt_oldpass.PasswordChar = '\0';
            }
            else
            {
                txt_oldpass.PasswordChar = '*';
            }
        }

        private void ShowPasswordNewChangeEventHandler(object sender, EventArgs e)
        {
            if (ckbShowPwdNew.Checked)
            {
                txt_newpass.PasswordChar = '\0';
            }
            else
            {
                txt_newpass.PasswordChar = '*';
            }
        }
    }
}
