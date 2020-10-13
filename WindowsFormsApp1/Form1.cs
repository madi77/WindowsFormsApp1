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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            var selectedItemToPass = listBox1.SelectedItem.ToString();

            //Form2 myform = new Form2(selectedItemToPass);

            Form2 form2 = new Form2();
            form2.PassValue(selectedItemToPass);
            form2.Show();
            
        }

      
    }
}
