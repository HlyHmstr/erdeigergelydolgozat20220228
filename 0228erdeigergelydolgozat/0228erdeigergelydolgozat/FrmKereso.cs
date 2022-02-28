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
    public partial class FrmKereso : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = nyelviskola;";

        public FrmKereso()
        {
            InitializeComponent();
        }

        private void FrmKereso_Load(object sender, EventArgs e)
        {
            cb_fill();
        }

        private void cb_fill()
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var r = new SqlCommand("SELECT nyelv " +
                    "FROM nyelvek " +
                    ";", c).ExecuteReader();
                while (r.Read())
                {
                    cb_nyelvek.Items.Add(r[0]);
                }
                c.Close();
            }
        }

        private void dgv_fill()
        {
            using (var c = new SqlConnection(connectionString))
            {
                dgv_kereso.Rows.Clear();
                string select = cb_nyelvek.SelectedItem.ToString();
                var dont = String.IsNullOrEmpty(select) ? ";" : "AND nyelvek.nyelv LIKE '" + select + "';";
                c.Open();
                var r = new SqlCommand("SELECT vizsgak.idopont,nyelvek.nyelv,vizsgak.szint " +
                    "FROM nyelvek,vizsgak,jelentkezesek " +
                    "WHERE nyelvek.id = vizsgak.nyelvid " +
                    "AND vizsgak.sorsz = jelentkezesek.vizsga" +
                    " "+ dont, c).ExecuteReader();
                while (r.Read())
                {
                    dgv_kereso.Rows.Add(r[0], r[1], r[2]);
                }
                c.Close();
            }
        }

        private void cb_nyelvek_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_fill();
        }
    }
}
