using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guproject1
{
    public partial class FrmLoggedInterface : Form
    {
        public FrmLoggedInterface()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchLadies_Click(object sender, EventArgs e)
        {
           

        }

        private void BtnLadiesWear_Click(object sender, EventArgs e)
        {
            ladiesCostumes lady = new ladiesCostumes();
            this.Hide();
            lady.Show();
        }

        private void BtnGentlemenWear_Click(object sender, EventArgs e)
        {
            boysCostume boy=new boysCostume();
            this.Hide();
            boy.Show();
        }

        private void FrmLoggedInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
