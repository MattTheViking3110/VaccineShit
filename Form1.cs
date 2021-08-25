using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VaccineShit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = Vaccine; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("Insert Into VaccineRegs(ID, FName, LName, Gender) Values ('" + this.txbID.Text + "', '" + this.txbFName.Text + "', '" + this.txbLName.Text + "', @gender);", con);
            cmd.Parameters.AddWithValue("@gender", cbxGender.SelectedItem);
            con.Open();
            try { 
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully registered");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid action");
            }
            con.Close();
           
        }
    }
}
