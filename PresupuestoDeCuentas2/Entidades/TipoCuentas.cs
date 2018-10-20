using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoDeCuentas2.Entidades
{
    public class TipoCuentas
    {
        [Key]
        public int TipoID { get; set; }
        public String Descripcion { get; set; }
        public TipoCuentas()
        {
            TipoID = 0;
            Descripcion = string.Empty;
        }
    }
}
