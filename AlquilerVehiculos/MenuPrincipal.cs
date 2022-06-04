using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerVehiculos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresarAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIngresarAutos Ingresar = new FormIngresarAutos();
            Ingresar.ShowDialog();
        }

        private void btnIngresarPersona_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIngresoPersonas IngresoPersonas = new FormIngresoPersonas();
            IngresoPersonas.ShowDialog();
        }

        private void btnEliminarMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEliminar eliminar = new FormEliminar();
            eliminar.ShowDialog();
        }

        private void btnBuscarPlaca_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBuscarPlaca placas = new FormBuscarPlaca();
            placas.ShowDialog();
        }

        private void btnCalcularRecibo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReciboPago recibo = new FormReciboPago();
            recibo.ShowDialog();
        }

        private void btnMesAlquiler_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAlquiladosMes alquiler = new FormAlquiladosMes();
            alquiler.ShowDialog();
        }
    }
}
