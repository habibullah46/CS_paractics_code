using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_calculator
{
    public partial class Form1 : Form
    {
        calculator mycall = new calculator();
       
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if(cmb_choice.Text == "Add")
            {
                try
                {
                    txt_answer.Text = mycall.Add(int.Parse(txt_valueOne.Text), int.Parse(txt_valueTwo.Text)).ToString();
                    clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("NOT VALID INPUT","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
               
            }
            else if (cmb_choice.Text == "Sub")
            {
                txt_answer.Text = mycall.sub(int.Parse(txt_valueOne.Text), int.Parse(txt_valueTwo.Text)).ToString();
               clear();
            }
            else if (cmb_choice.Text == "Mul")
            {
                txt_answer.Text = mycall.mul(int.Parse(txt_valueOne.Text), int.Parse(txt_valueTwo.Text)).ToString();
                clear();
            }
            else if (cmb_choice.Text == "Divid")
            {
                txt_answer.Text = mycall.divid(int.Parse(txt_valueOne.Text), int.Parse(txt_valueTwo.Text)).ToString();
                clear();
            }

        }
        private void clear()
        {
            txt_valueOne.Clear();
            txt_valueTwo.Clear();
            txt_valueOne.Focus();
        }
    }
}
