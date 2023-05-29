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

namespace MyStudentform
{
    public partial class Form1 : Form
    {
        string ConString = System.Configuration.ConfigurationManager.ConnectionStrings["myConString"].ToString();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Sqlcommand = "INSERT INTO tbl_student VALUES('"+txt_rigid.Text+"','"+txt_name.Text+"','"+txt_fatherName.Text+"','"+txt_Mobile.Text+"','"+txt_RolNo.Text+"','"+txt_email.Text+"','"+txt_address.Text+"')".ToString();
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Sqlcommand,con);
            cmd.ExecuteNonQuery();
        }
    }
}
