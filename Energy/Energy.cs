using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Energy
{
    public partial class Energy : Form
    {
        public Energy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Formula en = new Formula();

            double v2;
            Double.TryParse(textBox1.Text,out v2);
            double m2;
            Double.TryParse(textBox2.Text,out m2);

            textBox3.Text = en.e_count(v2, m2).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Energy_Load(object sender, EventArgs e)
        {
        }
    }
}
