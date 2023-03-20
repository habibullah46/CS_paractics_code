using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string LastOPerator = null;
        List<string> HistoryMantain = new List<string>();
        calculator cal = new calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cbn_choice.Text== "sum")
            {
                try
                {
                    LastOPerator= txt_answer.Text = cal.sum(Convert.ToInt32(txt_valueone.Text), Convert.ToInt32(txt_valueTwo.Text)).ToString();
                }
                catch(Exception ex) 
                {
                    //lbl_error.Text = "INVALID NUMBER YOU ENTER!!!", "Error", MessageboxButton.Ok, messageBoxIcon.Er;
                    MessageBox.Show("INVALID NUMBER YOU ENTER!!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                }
               
            }
            if(cbn_choice.Text == "mul")
            {
                try
                {
                    LastOPerator = txt_answer.Text = cal.mul(Convert.ToInt32(txt_valueone.Text), Convert.ToInt32(txt_valueTwo.Text)).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("INVALID INPUT YOU ENTER!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                }
             
            }
            if(cbn_choice.Text == "sub")
            {
                try
                {
                    LastOPerator = LastOPerator = txt_answer.Text = cal.sub(Convert.ToInt32(txt_valueone.Text), Convert.ToInt32(txt_valueTwo.Text)).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("INVALID NUMBER YOU ENTER", "Enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
               
            }
            if (cbn_choice.Text == "divid")
            {
                try
                {
                    LastOPerator = LastOPerator = txt_answer.Text = cal.divid(Convert.ToInt32(txt_valueone.Text), Convert.ToInt32(txt_valueTwo.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("INVALID NUMBER YOU ENTER!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            lbl_lastoperator.Text = "last operator is :" + LastOPerator;
            HistoryMantain.Add(LastOPerator);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txt_valueone.Clear();
            txt_valueTwo.Clear();
            txt_answer.Clear();
            txt_valueone.Focus();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            history History = new history();
            History.loadlist(HistoryMantain);
        }
    }
}
