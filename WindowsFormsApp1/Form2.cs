using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string selectedItem = String.Empty;

        public Form2(string value)
        {
            InitializeComponent();
            selectedItem = value;
        }




        private void button1_Click(object sender, EventArgs e)
        {
           textBox1.Text = selectedItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void PassValue(string strValue)
        {
            textBox1.Text = "dcsdc";
        }
    }
}
