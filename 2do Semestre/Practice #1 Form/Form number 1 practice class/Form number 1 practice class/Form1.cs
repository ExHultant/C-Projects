using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_number_1_practice_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Process_Click(object sender, EventArgs e)
        {
            int n1, n2, res;
            n1 = Int32.Parse(Box1.Text);
            n2 = Int32.Parse(Box2.Text);
            res = n1 + n2;
            Box3.Text = res.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Box1.Text = null;
            Box2.Text = null;
            Box3.Text = null;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void Box3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
