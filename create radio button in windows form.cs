// create radio button using windows form application
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                MessageBox.Show("You are from India");
            }
            else if(radioButton2.Checked==true)
            {
                MessageBox.Show("You are from America");
            }
            else if(radioButton3.Checked==true)
            {
                MessageBox.Show("You are from England");
            }
            else
            {
                MessageBox.Show("Please select the country");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton4.Checked==true)
            {
                this.BackColor = Color.Red;
            }
            else if(radioButton5.Checked==true)
            {
                this.BackColor = Color.Green;
            }
            else if(radioButton6.Checked==true)
            {
                this.BackColor = Color.Blue;
            }
        }
    }
}
