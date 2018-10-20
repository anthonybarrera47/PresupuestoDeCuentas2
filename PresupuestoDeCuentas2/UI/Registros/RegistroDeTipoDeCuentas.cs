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
    public partial class RegistroDeTipoDeCuentas : Form
    {
        RepositorioBase<TipoCuentas> repositorio;
        public RegistroDeTipoDeCuentas()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            errorProviderTipo.Clear();
            TipoIDnumericUpDown.Value = 0;
            DescripciontextBox1.Text = string.Empty;
        }
        private TipoCuentas LlenaClase()
        {
            TipoCuentas tipoCuentas = new TipoCuentas()
            {
                TipoID = Convert.ToInt32(TipoIDnumericUpDown.Value),
                Descripcion = DescripciontextBox1.Text
            };
            return tipoCuentas;
        }
        private void LlenaCampo(TipoCuentas tipoCuentas)
        {
            TipoIDnumericUpDown.Value = tipoCuentas.TipoID;
            DescripciontextBox1.Text = tipoCuentas.Descripcion;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<TipoCuentas>();
            TipoCuentas tipoCuentas = repositorio.Buscar((int)TipoIDnumericUpDown.Value);
            return (tipoCuentas != null);
        }
        private bool GuardarValidar()
        {
            bool paso = true;
            if (string.IsNullOrEmpty(DescripciontextBox1.Text))
            {
                errorProviderTipo.SetError(DescripciontextBox1, "El Campo Descripcion No puede Estar Vacio!");
                DescripciontextBox1.Focus();
                paso = false;
            }
            return paso;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<TipoCuentas>();
            TipoCuentas tipoCuentas;
            bool paso = false;
            tipoCuentas = LlenaClase();
            if (!GuardarValidar())
                return;
            if (TipoIDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(tipoCuentas);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar un Tipo de cuenta no Existente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(tipoCuentas);
            }
            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
            }
            else
                MessageBox.Show("No se Guardo el Tipo De Cuenta!!", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<TipoCuentas>();
            int.TryParse(TipoIDnumericUpDown.Text, out id);
            TipoCuentas tiposCuentas = new TipoCuentas();
            tiposCuentas = repositorio.Buscar(id);

            if (tiposCuentas != null)
            {
                MessageBox.Show("Tipo de Cuenta Encontrada.!!", "Exito!!!", MessageBoxButtons.OK);
                LlenaCampo(tiposCuentas);
            }
            else
                MessageBox.Show("Tipo de Cuenta no Encontrada", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<TipoCuentas>();
            int.TryParse(TipoIDnumericUpDown.Text, out id);
            if (!ExisteEnLaBaseDeDatos())
            {
                errorProviderTipo.SetError(TipoIDnumericUpDown, "Esta Cuenta No Existe");
                TipoIDnumericUpDown.Focus();
                return;
            }
            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("Tipo De Cuenta Eliminada!!", "Exitoso!!!", MessageBoxButtons.OK);
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo eliminar El Tipo De Cuenta!!", "Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
