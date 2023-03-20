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

namespace insert_data
{
    public partial class Form1 : Form
    {
        string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["mycon"].ToString();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {//insert k commmand likh raha hg 
         SqlConnection con = new SqlConnection(ConString);
         string sqlQuery = "INSERT INTO tbl_student VALUES('" + txt_RegistrationId.Text + "', '" + txt_name.Text + "','" + txt_fathername.Text + "','" + txt_mobile.Text + "','" + txt_Rno.Text + "','" + txt_address.Text + "')";
         //uper kiline sray insert k command ha 
         con.Open();
         SqlCommand cmd = new SqlCommand(sqlQuery,con);
         cmd.ExecuteNonQuery();
         con.Close();
        }
    }
}
