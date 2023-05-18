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

        private void btn_sum_Click(object sender, EventArgs e)
        {
            txt_answer.Text = mycall.Add(int.Parse(txt_valueOne.Text), int.Parse(txt_valueTwo.Text)).ToString();

        }

        private void btn_subtraction_Click(object sender, EventArgs e)
        {
            txt_answer.Text = mycall.sub(int.Parse(txt_valueOne.Text),int.Parse(txt_valueTwo.Text)).ToString();
        }
       
    }
}
