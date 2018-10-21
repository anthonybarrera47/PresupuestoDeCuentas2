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

namespace PresupuestoDeCuentas2.UI.Reportes
{
    public partial class ReporteViewer : Form
    {
        private List<Presupuesto> ListaPresupuesto;
        public ReporteViewer(List<Presupuesto> presupuestos)
        {
            this.ListaPresupuesto = presupuestos;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Reporte listado = new Reporte();
            listado.SetDataSource(ListaPresupuesto);

            PresupuestoCrystalReview.ReportSource = listado;
            PresupuestoCrystalReview.Refresh();
        }
    }
}
