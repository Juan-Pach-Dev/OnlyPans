using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyPans
{
    public partial class InicioSesión : Form
    {
        string UsuarioAdministrador = "PaolaLucia1990";
        string ContraseñaAdministrador = "Fqe3546";
        string UsuarioEmpleado1 = "MartínFerreira1996";
        string ContraseñaEmpleado1 = "Kjue6734";
        string UsuarioEmpleado2 = "LucasRojo2001";
        string ContraseñaEmpleado2 = "Tueg9318";


        public InicioSesión()
        {
            InitializeComponent();
        }

        private void Btniniciarsesion_Click(object sender, EventArgs e)
        {
            if(Txtusuario.Text == UsuarioAdministrador && Txtcontraseña.Text == ContraseñaAdministrador)
            {
                Txtusuario.Clear();
                Txtcontraseña.Clear();
                InfoAdministrador Main = new InfoAdministrador();
                Main.ShowDialog();

            }
            else
            {
                if (Txtusuario.Text == UsuarioEmpleado1 && Txtcontraseña.Text == ContraseñaEmpleado1)
                {
                    Txtusuario.Clear();
                    Txtcontraseña.Clear();
                    InfoEmpleados Main1 = new InfoEmpleados();
                    Main1.ShowDialog();
                }
                else
                {
                    if (Txtusuario.Text == UsuarioEmpleado2 && Txtcontraseña.Text == ContraseñaEmpleado2)
                    {
                        Txtusuario.Clear();
                        Txtcontraseña.Clear();
                        InfoEmpleados Main2 = new InfoEmpleados();
                        Main2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña no válido, Intente de nuevo");
                        Txtusuario.Clear();
                        Txtcontraseña.Clear();
                        Txtusuario.Focus();
                        Txtcontraseña.Focus();
                        return;
                    }
            

            }

            }
        }
    }
}
