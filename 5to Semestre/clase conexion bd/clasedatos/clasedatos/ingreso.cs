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
    public partial class ingreso : Form
    {
        int intentos = 0;
        //internal static: variables que permanecen en memoria hasta que se cierre la aplicacion 
        internal static int nivel;
        internal static string user;

        private void buscarUsu()
        { //variable para fila de una tabla
            DataRow fila;
            fila = dSingreso1.Usuario.Rows.Find(tbusuario.Text);
            if (fila == null)
            {
                limpiar();
            }
            else
            {
                if (fila[1].ToString() == tbcontra.Text){
                    Hide(); //para ocultar ventana ingreso
                    user = fila[0].ToString();
                    nivel = Convert.ToInt32(fila[2]);
                    menu Menu = new menu();
                    Menu.ShowDialog();
                    Close();
                }
                else
                {
                    limpiar();
                }
            }
        }
        private void limpiar()
        {
            if (intentos == 3) {
                MessageBox.Show("Ha superado el nro de intentos permitidos\nIntente mas tarde","Ingreso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show("Datos de acceso incorrectos","Incorrecto", MessageBoxButtons.OK,MessageBoxIcon.Information);
                tbusuario.Clear();
                tbusuario.Focus();
                tbcontra.Clear();
            }
        }
        public ingreso()
        {
            InitializeComponent();
        }

        private void ingreso_Load(object sender, EventArgs e)
        {
            //para llenar la tabla
            //limpiar las tablas
            dSingreso1.Clear();
            //traer datos
            sqlDA_usuario.Fill(dSingreso1.Usuario);
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (intentos < 3)
            {
                intentos++;
                buscarUsu();
            }
            else
            {
                limpiar();
            }
        }
    }
}
