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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            FrmRegistration obj= new FrmRegistration();
            this.Hide();
            obj.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String uname = TxtUserName.Text;
                String password = TxtUserPassword.Text;

                String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
                MySqlConnection con = new MySqlConnection(con_string);

                String query = "select UserName,Password from customer_deatails where UserName='" + uname + "' ";
                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    TxtUserName.Text = rdr.GetString(0);
                    TxtUserPassword.Text = rdr.GetString(1);

                    if (password == rdr.GetString(1))
                    {
                        FrmLoggedInterface log = new FrmLoggedInterface();
                        this.Hide();
                        log.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password!!");
                    }
                    
                }

                rdr.Close();
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception : " + ex.Message);
            }

        }

        private void PnlAppearance_Paint(object sender, PaintEventArgs e)
        {
            PnlAppearance.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            FrmAdminLogin log = new FrmAdminLogin();
            this.Hide();
            log.Show();

        }
    }
}
