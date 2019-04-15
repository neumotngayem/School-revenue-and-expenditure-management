using System;
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
    public partial class Frm_Main : Form
    {
        SqlConnection conn = DBUtils.getConnection();
        public Frm_Main()
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

        private void quảnLíGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
