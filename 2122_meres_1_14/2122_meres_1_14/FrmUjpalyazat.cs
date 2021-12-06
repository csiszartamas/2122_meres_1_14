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
        public FrmUjpalyazat(string connectionString)
        {

            InitializeComponent();
        }

        private void FrmUjpalyazat_Load(object sender, EventArgs e)
        {
            fillTB();
        }

        private void fillTB()
        {
            
        }
    }
}
