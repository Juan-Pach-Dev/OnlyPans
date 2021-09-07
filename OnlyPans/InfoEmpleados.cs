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
    public partial class InfoEmpleados : Form
    {
        public InfoEmpleados()
        {
            InitializeComponent();
        }

        private void Btnvender_Click(object sender, EventArgs e)
        {
            double Porcionaliñado, Porcionnoaliñado, Porcionespecial, Precioventa;

            Porcionaliñado = Convert.ToDouble(Txtporciónaliñado.Text);
            Porcionnoaliñado = Convert.ToDouble(Txtporciónoaliñado.Text);
            Porcionespecial = Convert.ToDouble(Txtporciónespecial.Text);
            Precioventa = ((Porcionaliñado * 1000) + (Porcionnoaliñado * 500) + (Porcionespecial * 2000));
            string Preciototalventa;
            Preciototalventa = Convert.ToString(Precioventa);
            Txtbprecioventa.Text = Preciototalventa;
            Rtbventashechas.Text = "REGISTRO DE VENTA \n" + "Datos del cliente \n" + "Nombre: " + Txtbnombre.Text + "\n"
            + "Cédula: " + Txtbcédula.Text + "\n" + "Datos de la venta \n" + "Tipo de pan \n" + "Aliñado: " + Txtporciónaliñado.Text 
            + "\n" + "No aliñado: " + Txtporciónoaliñado.Text + "\n" + "Especial: " + Txtporciónespecial.Text + "\n" + "Precio total de la venta: " + Txtbprecioventa.Text + "\n"
            + "Hora de la venta: " + Txtbhoraventa.Text + "\n" + "==========================================================================================\n" + Txtguardado.Text;
            Clipboard.SetText(Rtbventashechas.Text);
            Txtguardado.Text = Clipboard.GetText();
            Txtbnombre.Clear();
            Txtbcédula.Clear();
            Txtbpreciopanaliñeado.Clear();
            Txtbpreciopannoaliñado.Clear();
            Txtbpreciopanespecial.Clear();
            Txtbhoraventa.Clear();
        }

        private void Btncerrarusuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
