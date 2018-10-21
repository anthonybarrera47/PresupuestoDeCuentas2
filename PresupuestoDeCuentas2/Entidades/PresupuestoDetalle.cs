using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoDeCuentas2.Entidades
{
    public class PresupuestoDetalle
    {
        [Key]
        public int PresupuestoDetalleID { get; set; }
        public int PresupuestoID { get; set; }
        public int CuentaID { get; set; }
        public Double Valor { get; set; }
        public Double Total { get; set; }

        public PresupuestoDetalle()
        {
            PresupuestoDetalleID = 0;
            PresupuestoID = 0;
            CuentaID = 0;
            Valor = 0;
            Total = 0;
        }

        public PresupuestoDetalle(int PresupuestoDetalleID,int PresupuestoID,int CuentaID, Double Valor)
        {
            this.PresupuestoDetalleID = PresupuestoID;
            this.PresupuestoID = PresupuestoID;
            this.CuentaID = CuentaID;
            this.Valor = Valor;
           
        }

    }
}
