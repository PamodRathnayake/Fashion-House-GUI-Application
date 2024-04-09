using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guproject1
{
    public partial class ladiesCostumes : Form
    {
        public ladiesCostumes()
        {
            InitializeComponent();
        }

        private void BtnSearchLYcostumes_Click(object sender, EventArgs e)
        {
            String type = TxtLadyCostumeType.Text;
            String size= TxtLadyCostumeSize.Text;
            String colour= TxtLadyCostumeColour.Text;

            String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
            MySqlConnection con = new MySqlConnection(con_string);

            String query = "select price from ladies_costumes where type='" + type + "' and size='"+size+"' and colour='"+colour+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();

            MySqlDataReader my = cmd.ExecuteReader();
            while (my.Read())
            {
                TxtLadyCostumePrice.Text = my.GetDouble("price").ToString();
            }

            my.Close();
            con.Close();
        }

        private void BtnLYcostumeAddCart_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(TxtLadyCostumePrice.Text);

            double net_price = price + 350.00;

            TxtLadyCostumeNetPrice.Text = net_price.ToString();
        }

        private void TxtLadyCostumePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLCback_Click(object sender, EventArgs e)
        {
            FrmLoggedInterface loggedInterface= new FrmLoggedInterface();
            loggedInterface.Show();
            this.Close();
        }
    }
}
