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

namespace _0228erdeigergelydolgozat
{
    public partial class FrmVizsgazo : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = nyelviskola;";
        public FrmVizsgazo()
        {
            InitializeComponent();
        }

        private void FrmVizsgazo_Load(object sender, EventArgs e)
        {
            tb_id.Clear();
            tbfill();
            if (tb_id.Text != "")
            {
                btn_torles.Enabled = true;
                btn_uj.Enabled = true;
            }
        }

        private void tbfill()
        {
            using(var c = new SqlConnection(connectionString))
            {
                string name = FrmMain.vizsgazo_adatai.Neve;
                c.Open();
                var r = new SqlCommand("SELECT sorsz,mobil,szulev,nev FROM jelentkezesek " +
                    "WHERE nev LIKE '"+name+"';",c).ExecuteReader();
                while (r.Read())
                {
                    tb_id.Text = r[0].ToString();
                    tb_tel.Text = r[1].ToString();
                    tb_szul.Text = r[2].ToString();
                    tb_nev.Text = r[3].ToString();
                }
                c.Close();
            }
        }

        private void btn_ment_Click(object sender, EventArgs e)
        {

        }
    }
}
