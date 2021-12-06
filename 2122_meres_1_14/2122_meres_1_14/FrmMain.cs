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

namespace _2122_meres_1_14
{
    public partial class FrmMain : Form
    {
        public string ConnectionString { private get; set; }
        public FrmMain()
        {
            ConnectionString = "Server = (localdb)\\MSSQLLocalDB;" + "Database = palyazatok;";
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void FillDGV()
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                
                c.Open();
                //var keretosszeg = "SELECT tervezetA,tervezetB FROM palyazat;";
                var r = new SqlCommand("SELECT palyazat.id,sum(palyazat.tervezetC + palyazat.tervezetA), count(szamla.szamlaszam), sum(szamla.ertek) "
                    +"FROM koltsegtipus,szamla,palyazat "
                    +"WHERE palyazat.id = szamla.palyazatId "
                    +"and szamla.koltsegtipusId = koltsegtipus.id "
                    +"GROUP BY palyazat.id order by palyazat.id", c).ExecuteReader();

                while (r.Read())
                {
                    dgv.Rows.Add(r[0], r[1], r[2], r[3] );
                }
            }
        }

        private void btKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btUjpalyazat_Click(object sender, EventArgs e)
        {
            var frm = new FrmUjpalyazat(ConnectionString);
            frm.ShowDialog();
        }
    }
}
