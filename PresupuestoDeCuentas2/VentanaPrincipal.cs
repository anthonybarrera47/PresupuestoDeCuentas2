using PresupuestoDeCuentas2.UI.Consultas;
using PresupuestoDeCuentas2.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresupuestoDeCuentas2
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        

        private void registrarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPresupuesto registroPresupuesto = new RegistroPresupuesto();
            registroPresupuesto.MdiParent = this;
            registroPresupuesto.Show();
        }

        private void consultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaDeCuentas consultaDeCuentas = new ConsultaDeCuentas();
            consultaDeCuentas.MdiParent = this;
            consultaDeCuentas.Show();
        }
    }
}
