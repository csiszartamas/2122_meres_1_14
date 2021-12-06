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
    public partial class FrmUjpalyazat : Form
    {
        public string ConnectionString { private get; set; }
        public FrmUjpalyazat(string connectionString)
        {
            //adat = adat;
            ConnectionString = "Server = (localdb)\\MSSQLLocalDB;" + "Database = palyazatok;";
            InitializeComponent();
        }

        private void FrmUjpalyazat_Load(object sender, EventArgs e)
        {
            fillTB();
        }

        private void fillTB()
        {
            using (var c = new SqlConnection(ConnectionString))
            {

                c.Open();
                var r = new SqlCommand("SELECT szamla.palyazatId "
                    + "FROM szamla"
                    + ";", c).ExecuteReader();

                //tbID.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    MessageBox.Show("Csak számokat írj a mezőkbe, amik nagyobbak mint 0!");
                }
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
                {
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                    MessageBox.Show("Csak számokat írj a mezőkbe, amik nagyobbak mint 0!");
                }
            }
            else
            {

            }
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("Üresen hagytad valamelyik mezőt!");
            }
        }
    }
}
