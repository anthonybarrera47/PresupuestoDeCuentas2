using PresupuestoDeCuentas2.BLL;
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
        RepositorioBase<Presupuesto> repositorio;
        public RegistroPresupuesto()
        {
            InitializeComponent();
            this.Detalle = new List<PresupuestoDetalle>();
            LLenarComboBox();
        }

        private void Limpiar()
        {
            errorProvider.Clear();
            PresupuestoIDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            FechaTimePicker.Value = DateTime.Now;
            ValorTextBox.Text = string.Empty;
            TotalTextbox.Text = string.Empty;

            this.Detalle = new List<PresupuestoDetalle>();
            CargarGrid();
        }

        private Presupuesto LlenaClase()
        {
            Presupuesto presupuesto = new Presupuesto();
            presupuesto.PresupuestoID = Convert.ToInt32(PresupuestoIDnumericUpDown.Value);
            presupuesto.Descripcion = DescripciontextBox.Text;
            presupuesto.Fecha = FechaTimePicker.Value;
            presupuesto.Monto = Convert.ToDouble(ValorTextBox.Text);
            presupuesto.Presupuestos = this.Detalle;
            return presupuesto;
        }
        private void LlenaCampos(Presupuesto presupuesto)
        {
            PresupuestoIDnumericUpDown.Value = presupuesto.PresupuestoID;
            DescripciontextBox.Text = presupuesto.Descripcion;
            FechaTimePicker.Value = presupuesto.Fecha;
            ValorTextBox.Text = Convert.ToString(presupuesto.Monto);

            this.Detalle = presupuesto.Presupuestos;
            CargarGrid();
        }
        private void CargarGrid()
        {
            MontosDataGridView.DataSource = null;
            MontosDataGridView.DataSource = this.Detalle;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Presupuesto>();
            Presupuesto presupuesto = repositorio.Buscar((int)PresupuestoIDnumericUpDown.Value);
            return (presupuesto != null);
        }
        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();
            if(string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox, "El campo Descripcion no puede estar Vacio.");
                DescripciontextBox.Focus();
                paso = false;
            }
            if(this.Detalle.Count == 0)
            {
                errorProvider.SetError(CuentascomboBox, "Debe Agregar una o mas Cuentas");
                CuentascomboBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int ID;
            repositorio = new RepositorioBase<Presupuesto>();
            Presupuesto presupuesto = new Presupuesto();
            int.TryParse(PresupuestoIDnumericUpDown.Text, out ID);
            if (!ExisteEnLaBaseDeDatos())
                return;
            presupuesto = repositorio.Buscar(ID);
            if(presupuesto!=null)
            {
                errorProvider.Clear();
                LlenaCampos(presupuesto);
                MessageBox.Show("Presupuesto Encontrado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Presupuesto No Encontrado", "Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Presupuesto>();
            Presupuesto presupuesto;
            bool paso = false;

            presupuesto = LlenaClase();

            if (PresupuestoIDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(presupuesto);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Presupuesto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PresupuestoBLL.Modificar(presupuesto);
            }
            if (paso)
            {
                MessageBox.Show("Guardado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo Guardar!!", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int ID;
            repositorio = new RepositorioBase<Presupuesto>();
            int.TryParse(PresupuestoIDnumericUpDown.Text, out ID);

            if (!ExisteEnLaBaseDeDatos())
            {
                errorProvider.SetError(PresupuestoIDnumericUpDown, "No se puede eliminar un Presupuesto Inexistente");
                return;
            }
            if (repositorio.Eliminar(ID))
            {
                Limpiar();
                MessageBox.Show("Eliminado!!!", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddValor_Click(object sender, EventArgs e)
        {
            if (MontosDataGridView.DataSource != null)
                this.Detalle = (List<PresupuestoDetalle>)MontosDataGridView.DataSource;
            this.Detalle.Add(
                new PresupuestoDetalle(
                    PresupuestoDetalleID: 0,
                    PresupuestoID: (int)PresupuestoIDnumericUpDown.Value,
                    CuentaID: CuentascomboBox.SelectedIndex,
                    Valor: Convert.ToDouble(ValorTextBox.Text)
                    )
                );
            errorProvider.Clear();
            CargarGrid();
        }

        private void RemoverFila_Click(object sender, EventArgs e)
        {
            if(MontosDataGridView.Rows.Count > 0 && MontosDataGridView.CurrentRow !=null)
            {
                this.Detalle.RemoveAt(MontosDataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void AgregarCuentaButton_Click(object sender, EventArgs e)
        {
            RegistroDeCuentas registroDeCuentas = new RegistroDeCuentas();
            registroDeCuentas.Show();
            LLenarComboBox();
        }

        private void LLenarComboBox()
        {
            RepositorioBase<Cuenta> cuentaBLL = new RepositorioBase<Cuenta>();
            CuentascomboBox.DataSource = cuentaBLL.GetList(x => true);
            CuentascomboBox.ValueMember = "CuentasID";
            CuentascomboBox.DisplayMember = "Descripcion";
            
        }
    }
}
