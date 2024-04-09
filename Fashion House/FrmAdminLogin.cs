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
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        private void TxtUserPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdminSignUp_Click(object sender, EventArgs e)
        {
           // try
         //   {
                String name = TxtNewAdminName.Text;
                String password = TxtNewAdminPassword.Text;
                String email = TxtNewAdminEmail.Text;
                String address = TxtNewAdminAddress.Text;
                int phone = Convert.ToInt32(TxtNewAdminTelephone.Text);
                String admin_code = TxtNewAdminAdminCode.Text;



                String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
                MySqlConnection con = new MySqlConnection(con_string);

                String query = "insert into admin_details(AdminName,Password,Email,Address,Telephone,Admin_code) values('" + name + "','" + password + "','" + email + "','" + address + "'," + phone + ",'" + admin_code + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                TxtNewAdminName.Clear();
                TxtNewAdminPassword.Clear(); ;
                TxtNewAdminEmail.Clear();
                TxtNewAdminTelephone.Clear();
                TxtNewAdminAdminCode.Clear();
                TxtNewAdminAddress.Clear();
         //   }
           // catch(Exception ex)
            //{
             //   MessageBox.Show("Exception : " + ex.Message);
            //}
        }

        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            String name=TxtAdminName.Text;
            String password = TxtAdminPassword.Text;
            String admin_code = TxtNewAdminAdminCode.Text;


            String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
            MySqlConnection con = new MySqlConnection(con_string);

            String query = "select AdminName,Password,Admin_code from admin_details where AdminName='" + name + "' ";
            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();

            MySqlDataReader sql = cmd.ExecuteReader();
            while (sql.Read())
            {
               TxtAdminName.Text=sql.GetString(0);
               TxtAdminPassword.Text=sql.GetString(1);
                TxtNewAdminAdminCode.Text = sql.GetString(2);

            }

            sql.Close();
            con.Close();

            FrmAdinistratorControl adm = new FrmAdinistratorControl();
            this.Hide();
            adm.Show();

        }

        private void BtnALback_Click(object sender, EventArgs e)
        {
            FrmMain frm= new FrmMain(); 
            frm.Show();
            this.Hide();
        }
    }
    
}
