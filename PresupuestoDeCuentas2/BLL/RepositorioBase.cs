using PresupuestoDeCuentas2.DAL;
using PresupuestoDeCuentas2.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoDeCuentas2.BLL
{
    public class RepositorioBase<T> : IDisposable, IRepository<T> where T : class
    {
        internal Contexto _db;
        public RepositorioBase()
        {
            _db = new Contexto();
        }
        public T Buscar(int id)
        {
            T entity;
            try
            {
                entity = _db.Set<T>().Find(id);
            }catch(Exception)
            { throw; }
            return entity;
        }
        public bool Eliminar(int id)
        {
            bool paso = false;
            try
            {
                T entity = _db.Set<T>().Find(id);
                _db.Set<T>().Remove(entity);

                paso = _db.SaveChanges() > 0;
            }catch(Exception)
            { throw; }
            return paso;
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            List<T> list = new List<T>();
            try
            {
                list = _db.Set<T>().Where(expression).ToList();
            }catch(Exception)
            { throw; }
            return list;
        }

        public bool Guardar(T entity)
        {
            bool paso = false;
            try
            {
                if (_db.Set<T>().Add(entity) != null)
                    paso = _db.SaveChanges() > 0;
            }catch(Exception)
            { throw; }
            return paso;
        }

        public bool Modificar(T entity)
        {
            RepositorioBase<Presupuesto> repositorio = new RepositorioBase<Presupuesto>();
            bool paso = false;
            
            _db = new Contexto();
            try
            {
                /*_db.Entry(entity).State = EntityState.Modified;
                //paso = _db.SaveChanges() > 0;
                if(_db.SaveChanges()>0)
                {
                    paso = true;
                }*/

            }catch(Exception)
            { throw; }
            return paso;
        }
        public void Dispose()
        {
            _db.Dispose();
        }
       
    }
}
