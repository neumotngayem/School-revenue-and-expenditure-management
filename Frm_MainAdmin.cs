﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAOVO_QLTC
{
    public partial class Frm_MainAdmin : Form
    {
        SqlConnection conn = DBUtils.getConnection();
        public Frm_MainAdmin()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                Console.WriteLine("Okay");
            }catch(Exception e)
            {
                Console.WriteLine("Error: "+e);
            }
        }

        private void BtnCreateAccClickEventHandler(object sender, EventArgs e)
        {
            Frm_taotaikhoan frmNewAcc = new Frm_taotaikhoan();
            frmNewAcc.Show();
        }

        private void ChangePwdClickEventHandler(object sender, EventArgs e)
        {
            Frm_doimatkhau frmDoiMatKhau = new Frm_doimatkhau();
            frmDoiMatKhau.Show();
        }

        private void LogoutClickEventHandler(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                openForm.Hide();
            }
            Frm_dangnhap frmLogin = new Frm_dangnhap();
            frmLogin.Show();
        }
    }
}
