using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double a,n;
            a = Convert.ToInt32(textBox2.Text);
            n = a;
            if (n < 0)
            {
                n = n *-1 + 2;
            }
            textBox1.Text = Convert.ToString((a+1)*n/2);
        } 
    }
}
