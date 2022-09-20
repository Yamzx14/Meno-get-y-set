using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meno_get_y_set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //agraga el constructor
            menoclass men = new menoclass();
            men.N11=int.Parse(textBox1.Text);
            men.N21 = int.Parse(textBox2.Text);

            textBox3.Text = men.meno().ToString();
        }
    }
}
