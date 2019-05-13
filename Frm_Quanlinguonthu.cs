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
    public partial class Frm_Quanlinguonthu : Form
    {
        public Frm_Quanlinguonthu()
        {
            InitializeComponent();
        }



        public void LoadGridData()
        {
            SqlConnection conn = DBUtils.getConnection();
            conn.Open();
            SqlDataAdapter dataAdapter;
            dataAdapter = new SqlDataAdapter("Select nt.*, CASE WHEN nt.loainguoinop = 'hs' THEN hs.hoten ELSE gv.tengv END AS tennguoinop  from NGUONTHU nt LEFT JOIN GIAOVIEN gv ON gv.magv = nt.manguoinop LEFT JOIN HOCSINH hs ON hs.mahs = nt.manguoinop JOIN NHANVIEN nv ON nv.manhanvien = nt.nguoithu", conn);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            dataAdapter.Dispose();

            grdnguonthu.DataSource = dataTable;
            grdnguonthu.Refresh();
        }

        private void btnXuatPhieuThu_Click(object sender, EventArgs e)
        {
            Frm_Phieuthu frm_Phieuthu = new Frm_Phieuthu(this);
            frm_Phieuthu.Show();
        }
    }
}
