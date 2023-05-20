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
    public partial class HistoryMantian : Form
    {
        public HistoryMantian()
        {
            InitializeComponent();
        }
        public void loadlist(List<string> mylist) 
        {
            listBox1.DataSource = mylist;
            this.ShowDialog();
        }
    }
}
