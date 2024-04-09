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
    public partial class boysCostume : Form
    {
        public boysCostume()
        {
            InitializeComponent();
        }

        private void BtnSearchMencostumes_Click(object sender, EventArgs e)
        {
            String mtype=TxtMenCostumeType.Text;
            String msize=TxtMenCostumeSize.Text;
            String mcolour=TxtMenCostumeColour.Text;

            String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
            MySqlConnection con = new MySqlConnection(con_string);

            String query = "select price from male_costumes where type='"+mtype+"' and size='"+msize+"' and colour='"+mcolour+"'";
            MySqlCommand cmd= new MySqlCommand(query, con);

            con.Open();

            MySqlDataReader data= cmd.ExecuteReader();
            while (data.Read())
            {
                TxtMenCostumePrice.Text = data.GetDouble("price").ToString();
            }

            data.Close();
            con.Close();
        }

        private void BtnMencostumeAddCart_Click(object sender, EventArgs e)
        {
            double Mprice = Convert.ToDouble(TxtMenCostumePrice.Text);

            double net_price = Mprice + 350.00;

            TxtMenCostumeNetPrice.Text = net_price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLoggedInterface frm= new FrmLoggedInterface();
            frm.Show();
            this.Close();
        }
    }
}
