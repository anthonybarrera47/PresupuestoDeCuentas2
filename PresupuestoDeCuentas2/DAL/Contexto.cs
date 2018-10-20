using PresupuestoDeCuentas2.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoDeCuentas2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<TipoCuentas> TipoCuentas { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }
        public Contexto() : base("ConStr")
        { }
    }
}
