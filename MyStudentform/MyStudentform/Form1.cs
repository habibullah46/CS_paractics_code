using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyStudentform
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Sqlcommand = "INSERT INTO tbl_student VALUES('"+txt_rigid.Text+"','"+txt_name.Text+"','"+txt_fatherName.Text+"','"+txt_Mobile.Text+"','"+txt_RolNo.Text+"','"+txt_email.Text+"','"+txt_address.Text+"')".ToString();
            SqlConnection con = new SqlConnection(Helerclass.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Sqlcommand,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save Successfully!","Alert",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            Helerclass.Clear(this);
            this.tbl_studentTableAdapter.Fill(this.studentDBDataSet.tbl_student);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.studentDBDataSet.tbl_student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          Editstudent obj = new Editstudent();
          obj.Show();
        }
    }
}
