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
using System.Data.SqlClient;

namespace studentform
{
    public partial class Form1 : Form
    {
        string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string commandquery = "INSERT INTO tbl_student VALUES ('"+txt_regid.Text+"','"+txt_name.Text+"','"+txt_fathername.Text+"','"+txt_mobile.Text+"','"+txt_RollNo.Text+"','"+txt_address.Text+"')";
           SqlConnection con = new SqlConnection(ConString);
           con.Open();
            SqlCommand cmd = new SqlCommand(commandquery,con);
            cmd.ExecuteNonQuery();
            
        }

        private void txt_regid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
 