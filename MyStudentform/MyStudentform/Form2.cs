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
    public partial class Editstudent : Form
    {
       
        public Editstudent()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet1.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.studentDBDataSet1.tbl_student);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            string Querry = "SELECT * FROM tbl_student Where RegistrationID = '"+cmd_rigister.Text+"'".ToString();
             SqlConnection con = new SqlConnection(Helerclass.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Querry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) 
            { 
                txt_name.Text = dr["Name"].ToString();
                txt_RolNo.Text = dr["RNo"].ToString();
                txt_Mobile.Text = dr["Mobile"].ToString();
                txt_fatherName.Text = dr["FatherName"].ToString();
                txt_email.Text = dr["Email"].ToString() ;
                txt_address.Text = dr["Address"].ToString();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           DialogResult DR = MessageBox.Show("Do u Want To Delete"+txt_name.Text+"Record","conformation message",MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                string DeleteQuery = "DELETE tbl_student WHERE RegistrationID = '" + cmd_rigister.Text + "'".ToString();
                SqlConnection con = new SqlConnection(Helerclass.ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(DeleteQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Helerclass.Clear(this);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string UpdateQuery = "UPDATE tbl_student SET Name='"+txt_name.Text+"',FatherName = '"+txt_fatherName.Text+"',Mobile='"+txt_Mobile.Text+"',RNo='"+txt_RolNo.Text+"',Email='"+txt_email.Text+"',Address='"+txt_address.Text+"' ";
            SqlConnection con = new SqlConnection(Helerclass.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(UpdateQuery, con);
            cmd.ExecuteNonQuery();
             MessageBox.Show("Udate Successfully!","sucessfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
