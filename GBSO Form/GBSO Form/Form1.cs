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

namespace GBSO_Form
{
    public partial class Form1 : Form
    {
        string myconstring = System.Configuration.ConfigurationManager.ConnectionStrings["myConString"].ToString();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string command = "INSERT INTO tbl_GBSO VALUES('" + txt_name.Text + "','" + txt_fname.Text + "','" + txt_cnic.Text + "','" + txt_department.Text + "','" + txt_batch.Text + "','"+txt_phoneno.Text+"','" + cmd_address.Text + "')";
        
           
            
            SqlConnection con = new SqlConnection(myconstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(command, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Save Record Successfully!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.tbl_GBSOTableAdapter.Fill(this.gBSORegistrationDataSet.tbl_GBSO);
            this.tbl_GBSOTableAdapter1.Fill(this.gBSORegistrationDataSet2.tbl_GBSO);
            Clear(this);


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
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gBSORegistrationDataSet2.tbl_GBSO' table. You can move, or remove it, as needed.
           this.tbl_GBSOTableAdapter1.Fill(this.gBSORegistrationDataSet2.tbl_GBSO);
            // TODO: This line of code loads data into the 'gBSORegistrationDataSet.tbl_GBSO' table. You can move, or remove it, as needed.
            this.tbl_GBSOTableAdapter.Fill(this.gBSORegistrationDataSet.tbl_GBSO);

        }
     


        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit_Form EF = new Edit_Form();
            EF.ShowDialog();
        }
        
        
     
    }
}
