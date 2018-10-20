using PresupuestoDeCuentas2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresupuestoDeCuentas2.UI.Registros
{
    public partial class RegistroPresupuesto : Form
    {
        public List<PresupuestoDetalle> Detalle { get; set; }
        public RegistroPresupuesto()
        {
            InitializeComponent();
            this.Detalle = new List<PresupuestoDetalle>();
        }

        private void Limpiar()
        {
            errorProvider.Clear();
            PresupuestoIDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            FechaTimePicker.Value = DateTime.Now;
            ValorTextBox.Text = string.Empty;
            TotalTextbox = string.Empty;

            this.Detalle = new List<PresupuestoDetalle>();
            CargarGrid();
        }

        public Persona LlenaClase()
        {
            Presupuesto presupuesto = new Presupuesto();
            presupuesto.PresupuestoID = Convert.ToInt32(PresupuestoIDnumericUpDown.Value);
            presupuesto.Descripcion = DescripciontextBox.Text;
            presupuesto.Fecha = FechaTimePicker.Value;

            presupuesto.Presupuestos = this.Detalle;
        }

     
    }
}
