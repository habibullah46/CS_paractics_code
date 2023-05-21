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
        string history = null;
       List <string> savehistoy = new List<string>();
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
                    history = txt_answer.Text = mycall.Add(int.Parse(txt_valueOne.Text), int.Parse(txt_valueTwo.Text)).ToString();
                       
                       

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("NOT VALID INPUT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clear();
                    }
                

               
            }
            else if (cmb_choice.Text == "Sub")
            {
                try
                {
                    history = txt_answer.Text = mycall.sub(int.Parse(txt_valueOne.Text), int.Parse(txt_valueTwo.Text)).ToString();
                    
                 

                }
                catch (Exception ex) 
                {
                    MessageBox.Show("INVALID INPUT ", "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
             
            }
            else if (cmb_choice.Text == "Mul")
            {
                try
                {
                  history=txt_answer.Text = mycall.mul(int.Parse(txt_valueOne.Text), int.Parse(txt_valueTwo.Text)).ToString();
                    
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("INVALID INPUT ", " ERROR" , MessageBoxButtons.OK,MessageBoxIcon.Error);
                    clear();
                }
             
            }
            else if (cmb_choice.Text == "Divid")
            {
                try
                {
                    history = txt_answer.Text = mycall.divid(int.Parse(txt_valueOne.Text), int.Parse(txt_valueTwo.Text)).ToString();
                    
                     
                }
                catch (Exception ex)
                {
                    MessageBox.Show("INVALID INPUT ", " ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                    clear();
                }
               
            }

            lbl_lastans.Text = txt_valueOne.Text+" + "+txt_valueTwo.Text+" = "+ history;
            
            savehistoy.Add(lbl_lastans.Text);
            clear();
        }
       
        private void clear()
        {
            txt_valueOne.Clear();
            txt_valueTwo.Clear();
            txt_valueOne.Focus();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            HistoryMantian myhistory = new HistoryMantian();
            myhistory.loadlist(savehistoy);

        }
    }
}
