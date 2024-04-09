using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guproject1
{
    public partial class FrmAdinistratorControl : Form
    {
        public FrmAdinistratorControl()
        {
            InitializeComponent();
        }

        private void BtnSaveLadyCostumes_Click(object sender, EventArgs e)
        {
            String L_code=TxtLadyCstDressCode.Text;
            String type = TxtLadyCstType.Text;
            String colour = TxtLadyCstColour.Text;
            String size = TxtLadyCstSize.Text;
            double price = Convert.ToDouble(TxtLadyCstPrice.Text);
            int stock = Convert.ToInt32(TxtLadyCstStock.Text);

            String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
            MySqlConnection con = new MySqlConnection(con_string);

            String query = "insert into ladies_costumes(Ldress_code,type,colour,size,price,stock) values('"+ L_code + "','" + type+"','"+colour+"','"+size+"',"+price+","+stock+")";
            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Inserted Successfully!!");

            TxtLadyCstDressCode.Clear();
            TxtLadyCstType.Clear();
            TxtLadyCstColour.Clear();
            TxtLadyCstSize.Clear();
            TxtLadyCstPrice.Clear();
            TxtLadyCstStock.Clear();

        }

        private void BtnSaveMaleCostumes_Click(object sender, EventArgs e)
        {
            String M_code=TxtMaleCstDressCode.Text;
            String Mtype=TxtMaleCstType.Text;
            String Mcolour=TxtMaleCstColour.Text;
            String Msize=TxtMaleCstSize.Text;
            double Mprice=Convert.ToDouble(TxtMaleCstPrice.Text);
            int Mstock=Convert.ToInt32((TxtMaleCstStock.Text));

            String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
            MySqlConnection con = new MySqlConnection(con_string);

            String query = "insert into male_costumes(Mdress_code,type,colour,size,price,stock) values('"+ M_code+ "','" + Mtype + "','" + Mcolour + "','" + Msize + "'," + Mprice + "," + Mstock + ")";
            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Inserted Successfully!!");

            TxtMaleCstDressCode.Clear();
            TxtMaleCstType.Clear();
            TxtMaleCstColour.Clear();
            TxtMaleCstSize.Clear();
            TxtMaleCstPrice.Clear();
            TxtMaleCstStock.Clear();


        }

        private void BtnUpdateLadyCostumes_Click(object sender, EventArgs e)
        {
            String L_code = TxtLadyCstDressCode.Text;
            String type = TxtLadyCstType.Text;
            String colour = TxtLadyCstColour.Text;
            String size = TxtLadyCstSize.Text;
            double price = Convert.ToDouble(TxtLadyCstPrice.Text);
            int stock = Convert.ToInt32(TxtLadyCstStock.Text);

            String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
            MySqlConnection con = new MySqlConnection(con_string);

            String query = "update ladies_costumes set type='" + type + "',colour='" + colour + "',size='" + size + "',price=" + price + ",stock=" + stock + " where Ldress_code= '"+ L_code + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Updated Successfully!!");

            TxtLadyCstDressCode.Clear();
            TxtLadyCstType.Clear();
            TxtLadyCstColour.Clear();
            TxtLadyCstSize.Clear();
            TxtLadyCstPrice.Clear();
            TxtLadyCstStock.Clear();
        }

        private void BtnSearchLadyCostumes_Click(object sender, EventArgs e)
        {
            String L_code = TxtLadyCstDressCode.Text;

            String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
            MySqlConnection con = new MySqlConnection(con_string);

            String query = "select type,colour,size,price,stock from ladies_costumes where Ldress_code= '"+ L_code + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                TxtLadyCstType.Text=rdr.GetString("type");
                TxtLadyCstColour.Text=rdr.GetString ("colour");
                TxtLadyCstSize.Text=rdr.GetString("size");  
                TxtLadyCstPrice.Text=rdr.GetDouble("price").ToString();
                TxtLadyCstStock.Text=rdr.GetInt32("stock").ToString();
            }

            rdr.Close();
            con.Close();

            
        }

        private void BtnDeleteLadyCostumes_Click(object sender, EventArgs e)
        {
            String L_code = TxtLadyCstDressCode.Text;

            String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
            MySqlConnection con = new MySqlConnection(con_string);

            String query = "delete from ladies_costumes  where Ldress_code= '" + L_code + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Deleted!!");
        }

        private void BtnUpdateMaleCostumes_Click(object sender, EventArgs e)
        {

            String M_code = TxtMaleCstDressCode.Text;
            String Mtype = TxtMaleCstType.Text;
            String Mcolour = TxtMaleCstColour.Text;
            String Msize = TxtMaleCstSize.Text;
            double Mprice = Convert.ToDouble(TxtMaleCstPrice.Text);
            int Mstock = Convert.ToInt32((TxtMaleCstStock.Text));

            String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
            MySqlConnection con = new MySqlConnection(con_string);

            String query = "update male_costumes set type='" + Mtype + "',colour='" + Mcolour + "',size='" + Msize + "',price=" + Mprice + ",stock=" + Mstock + " where Mdress_code= '"+ M_code + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Updated Successfully!!");

            TxtMaleCstDressCode.Clear();
            TxtMaleCstType.Clear();
            TxtMaleCstColour.Clear();
            TxtMaleCstSize.Clear();
            TxtMaleCstPrice.Clear();
            TxtMaleCstStock.Clear();
        }

        private void BtnSearchMaleCostumes_Click(object sender, EventArgs e)
        {
            String M_code = TxtMaleCstDressCode.Text;

            String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
            MySqlConnection con = new MySqlConnection(con_string);

            String query = "select type,colour,size,price,stock from male_costumes where Mdress_code= '" + M_code + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                TxtMaleCstType.Text = rdr.GetString("type");
                TxtMaleCstColour.Text = rdr.GetString("colour");
                TxtMaleCstSize.Text = rdr.GetString("size");
                TxtMaleCstPrice.Text = rdr.GetDouble("price").ToString();
                TxtMaleCstStock.Text = rdr.GetInt32("stock").ToString();
            }

            rdr.Close();
            con.Close();
        }

        private void BtnDeleteMaleCostumes_Click(object sender, EventArgs e)
        {
            String M_code = TxtMaleCstDressCode.Text;

            String con_string = "server=127.0.0.1;user=root;password=;database=fashionhouse";
            MySqlConnection con = new MySqlConnection(con_string);

            String query = "delete from male_costumes  where Mdress_code= '" + M_code + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Deleted!!");
        }

        private void BtnACback_Click(object sender, EventArgs e)
        {
            FrmAdminLogin login= new FrmAdminLogin();
            login.Show();
            this.Hide();
        }
    }
}
