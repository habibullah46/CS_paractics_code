using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBSO_Form
{
    public partial class Edit_Form : Form
    {
        string connt = System.Configuration.ConfigurationManager.ConnectionStrings["myConString"].ToString();

        public Edit_Form()
        {
            InitializeComponent();
        }

        private void Edit_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gBSORegistrationDataSet1.tbl_GBSO' table. You can move, or remove it, as needed.
            this.tbl_GBSOTableAdapter.Fill(this.gBSORegistrationDataSet1.tbl_GBSO);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Qery = "SELECT * FROM tbl_GBSO WHERE CNIC = '" + cmd_cnic.Text + "'".ToString();
            SqlConnection con = new SqlConnection(connt);
            con.Open();
            SqlCommand cmd = new SqlCommand(Qery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_name.Text = dr["Name"].ToString();
                txt_fname.Text = dr["FName"].ToString();
                txt_department.Text = dr["Department"].ToString();
                txt_batch.Text = dr["Batch"].ToString();
                txt_phone.Text = dr["Phone"].ToString();
                cmd_address.Text = dr["Address"].ToString();

            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Do u Want To Delete" + txt_name.Text + "Record", "conformation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (DR == DialogResult.Yes)
            {
                string query = "DELETE tbl_GBSO WHERE CNIC = '" + cmd_cnic.Text + "'".ToString();
                SqlConnection con = new SqlConnection(connt);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Clear(this);

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do u want to update " + txt_name.Text + " Data", "conformation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string updatequery = "UPDATE tbl_GBSO SET  Name = '" + txt_name.Text + "',FName='" + txt_fname.Text + "',Department='" + txt_department.Text + "',Batch='" + txt_batch.Text + "',Phone ='" + txt_phone.Text + "',Address='" + cmd_address.Text + "'".ToString();
                SqlConnection con = new SqlConnection(connt);
                con.Open();
                SqlCommand cmd = new SqlCommand(updatequery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Clear(this);
            }
        }
        private void Clear(Form form)
        {
            foreach (var item in form.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }
    }
}
