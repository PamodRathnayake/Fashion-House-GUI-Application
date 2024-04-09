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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String name = TxtCusUserName.Text;
                String email = TxtCustomerEmail.Text;
                String password=TxtPassword.Text;
                int phone = Convert.ToInt32(TxtCustomerContactNumber.Text);
                String address = TxtCustomerAddress.Text;
                
                

                String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
                MySqlConnection con = new MySqlConnection(con_string);

                String query = "insert into customer_deatails(UserName,Email,Password,PhoneNumber,Address) values('" + name + "','" + email + "','" + password + "','" + phone + "','"+address+"')";
                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                TxtCusUserName.Clear();
                TxtCustomerEmail.Clear();
                TxtPassword.Clear();
                TxtCustomerContactNumber.Clear();
                TxtCustomerAddress.Clear();

                FrmMain obj= new FrmMain();
                this.Hide();
                obj.Show();
            }
            catch(Exception ex)
            {
      
                
                MessageBox.Show("Exception : " + ex.Message);

            }
        }

        private void TxtCustomerEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void BtnRFback_Click(object sender, EventArgs e)
        {
            FrmMain obj= new FrmMain();
            obj.Show();
            this.Hide();
        }
    }
}
