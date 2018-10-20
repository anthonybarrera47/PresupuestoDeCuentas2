using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoDeCuentas2.Entidades
{
    public class Cuenta
    {
        [Key]
        public int CuentasID { get; set; }
        public String Descripcion { get; set; }
        public int TipoID { get; set; }
        public Double Monto { get; set; }

        public Cuenta()
        {
            CuentasID = 0;
            Descripcion = string.Empty;
            TipoID = 0;
            Monto = 0;
        }
    }
}
