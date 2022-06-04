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
    public partial class FormIngresoPersonas : Form
    {
        public FormIngresoPersonas()
        {
            InitializeComponent();
            
            comboTipoCliente.SelectedIndex = 0;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.ShowDialog();
        }

        private void btnRegistrarPersonas_Click(object sender, EventArgs e)
        {
            if ((txtIDpropietario.Text != " ") || (txtNombrePropietario.Text != " "))
            {
                
            }
       
        }
    }
}
