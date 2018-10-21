using PresupuestoDeCuentas2.DAL;
using PresupuestoDeCuentas2.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoDeCuentas2.BLL
{
    public class PresupuestoBLL
    {
        public static Presupuesto Buscar(int id)
        {
            Contexto db = new Contexto();
            Presupuesto presupuesto = new Presupuesto();
            try
            {
                presupuesto = db.Presupuestos.Find(id);
                presupuesto.Presupuestos.Count();
            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return presupuesto;
        }
        public static bool Modificar(Presupuesto presupuesto)
        {
            
            bool paso = false;
            var Anterior = PresupuestoBLL.Buscar(presupuesto.PresupuestoID);
            Contexto db = new Contexto();
            try
            {
                foreach (var item in Anterior.Presupuestos)
                {
                    if (!presupuesto.Presupuestos.Exists(d => d.PresupuestoID == item.PresupuestoID))
                        db.Entry(item).State = EntityState.Deleted;
                }
                foreach (var item in presupuesto.Presupuestos)
                {
                    var estado = (item.PresupuestoID == 0) ? EntityState.Added : EntityState.Modified;
                    db.Entry(item).State = estado;
                }
                db.Entry(presupuesto).State = EntityState.Modified;
                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return paso;
        }
    }
}
