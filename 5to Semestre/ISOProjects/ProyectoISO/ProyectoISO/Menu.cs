using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoISO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editorial ventanaEditorial = new Editorial();
            ventanaEditorial.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados ventanaEmpleados = new Empleados();
            ventanaEmpleados.Show();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargos ventanaCargos = new Cargos();
            ventanaCargos.Show();
        }
        private void tiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tienda ventanaTienda = new Tienda();
            ventanaTienda.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\calc.exe"); // se coloca doble barra para que no de error
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\Microsoft Office\\root\\Office16\\WINWORD.exe");
        }
        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\Microsoft Office\\root\\Office16\\EXCEL.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("¿Estas Seguro De Salir?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Close();
            } 

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            for (int x = toolStripProgressBar1.Minimum; x < toolStripProgressBar1.Maximum; x++)
            { toolStripProgressBar1.Value = x; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void statusStrip1_ItemClicked(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }
        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("¿ Estas Seguro De Salir ?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedItem)
            {
                case "Word":
                    System.Diagnostics.Process.Start("C:\\Program Files\\Microsoft Office\\root\\Office16\\WINWORD.exe");
                        break;


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
