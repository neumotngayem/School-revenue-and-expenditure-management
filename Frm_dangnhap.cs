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
    public partial class Frm_dangnhap : Form
    {
        public Frm_dangnhap()
        {
            InitializeComponent();
        }

        private void ChangeShowPasswordEventHandler(object sender, EventArgs e)
        {
            if (ckbShowPwd.Checked)
            {
                txtPwd.PasswordChar = '\0';
            }
            else
            {
                txtPwd.PasswordChar = '*';
            }
        }

        private void UsernameValidatingEventHandler(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider.SetError(txtUsername, "Should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPwd, "");
            }
        }

        private void PasswordValidatingEventHandler(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPwd.Text))
            {
                e.Cancel = true;
                txtPwd.Focus();
                errorProvider.SetError(txtPwd, "Should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPwd, "");
            }
        }

        private void BtnLoginClickEventHandler(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using(MD5 md5Hash = MD5.Create())
                {
                    SqlConnection conn = DBUtils.getConnection();
                    conn.Open();
                    string md5PwdInput = GetMd5Hash(md5Hash, txtPwd.Text);
                    String usernameInput = txtUsername.Text;
                     
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = "Select quyenid from NGUOIDUNG WHERE username = @Username AND password = @Password";

                    SqlParameter paramUsername = new SqlParameter();
                    paramUsername.ParameterName = "@Username";
                    paramUsername.Value = usernameInput;
                    command.Parameters.Add(paramUsername);

                    SqlParameter paramPassword = new SqlParameter();
                    paramPassword.ParameterName = "@Password";
                    paramPassword.Value = md5PwdInput;
                    command.Parameters.Add(paramPassword);

                    // get data stream
                   SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string roleAcc = reader.GetString(0);
                        // Đóng kết nối.
                        conn.Close();
                        // Hủy đối tượng, giải phóng tài nguyên.
                        conn.Dispose();
                        if(roleAcc == "ADM")
                        {
                            Frm_MainAdmin mainAdmin = new Frm_MainAdmin();
                            mainAdmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            Frm_Main main = new Frm_Main();
                            main.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username hoặc Password sai", "Login");
                        // Đóng kết nối.
                        conn.Close();
                        // Hủy đối tượng, giải phóng tài nguyên.
                        conn.Dispose();
                    }                   
                }
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
    }
}
