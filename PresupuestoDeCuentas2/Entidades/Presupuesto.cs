using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoDeCuentas2.Entidades
{
    public class Presupuesto
    {
        [Key]
        public int PresupuestoID { get; set; }
        public DateTime Fecha { get; set; }
        public String Descripcion { get; set; }
        public Double Monto { get; set; }

        public virtual List<PresupuestoDetalle> Presupuestos { get; set; }
        public Presupuesto()
        {
            PresupuestoID = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Monto = 0;
            Presupuestos = new List<PresupuestoDetalle>();
        }
    }
}
