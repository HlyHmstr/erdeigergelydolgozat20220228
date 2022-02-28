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
    public partial class FrmMain : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = nyelviskola;";
        public FrmMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_fill();
        }

        private void dgv_fill()
        {
            using (var c = new SqlConnection(connectionString))
            {
                c.Open();
                var r = new SqlCommand("SELECT nyelvek.id,jelentkezesek.nev,nyelvek.nyelv,vizsgak.szint " +
                    "FROM nyelvek,vizsgak,jelentkezesek " +
                    "WHERE nyelvek.id = vizsgak.nyelvid " +
                    "AND vizsgak.sorsz = jelentkezesek.vizsga;", c).ExecuteReader();
                while (r.Read())
                {
                    dgv_main.Rows.Add(r[0], r[1], r[2], r[3]);
                }
                c.Close();
            }
        }

        private void tsm_vizsgak_Click(object sender, EventArgs e)
        {
            new FrmKereso().ShowDialog();
        }

        private void tsm_ujvizsgazo_Click(object sender, EventArgs e)
        {
            new FrmVizsgazo().ShowDialog();
        }
        private void dgv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vizsgazo_adatai.Neve = dgv_main[1, e.RowIndex].Value.ToString();
            new FrmVizsgazo().ShowDialog();
            vizsgazo_adatai.Neve = "";
        }
        public class vizsgazo_adatai
        {
            public static string Neve { get; set; }
        }
    }
}
