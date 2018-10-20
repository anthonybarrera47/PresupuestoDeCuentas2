using Microsoft.VisualStudio.TestTools.UnitTesting;
using PresupuestoDeCuentas2.BLL;
using PresupuestoDeCuentas2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoDeCuentas2.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void BuscarTest()
        {
            
        }

        [TestMethod()]
        public void EliminarTest()
        {
            
        }

        [TestMethod()]
        public void GetListTest()
        {
            
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<TipoCuentas> repositorio = new RepositorioBase<TipoCuentas>();
            bool paso = false;
            TipoCuentas tipoCuentas = new TipoCuentas
            {
                TipoID = 1,
                Descripcion = "Movil"
            };
            paso = repositorio.Guardar(tipoCuentas);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            
        }

        [TestMethod()]
        public void DisposeTest()
        {
            
        }
    }
}