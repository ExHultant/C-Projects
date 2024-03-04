using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clasedatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            timer1.Stop(); //para que el timer se de una sola vez
            Hide(); //esconde el formulario
            ingreso Ingreso = new ingreso();
            Ingreso.ShowDialog();
            Close(); //cierra el form1
        }
    }
}
