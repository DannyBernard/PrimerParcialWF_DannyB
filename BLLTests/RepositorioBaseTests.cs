using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Linq.Expressions;

namespace BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        private Prueba GetPrueba()
        {
            Prueba p = new Prueba();
            //  p.PruebaID = 1;
            p.NobrePrueba = "test1";

            return p;
        }

        [TestMethod()]
        public void GuardarTest()
        {
            BLL.RepositorioBase<Prueba> repositorio = new RepositorioBase<Prueba>();
            Assert.IsTrue(repositorio.Guardar(GetPrueba()));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Prueba p = new Prueba();
            p.PruebaID = 1;
            p.NobrePrueba = "testp1";

            BLL.RepositorioBase<Prueba> repositorioBase = new RepositorioBase<Prueba>();
            Assert.IsTrue(repositorioBase.Modificar(p));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 1;
            Prueba p = new Prueba();
            RepositorioBase<Prueba> repositorioBase = new RepositorioBase<Prueba>();
            p = repositorioBase.Buscar(id);
            Assert.AreEqual(true, p != null);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Prueba> repositorioBase = new RepositorioBase<Prueba>();
            List<Prueba> lista = new List<Prueba>();
            Expression<Func<Prueba, bool>> resultado = u => true;
            lista = repositorioBase.GetList(resultado);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Prueba p = new Prueba();
            RepositorioBase<Prueba> repositorioBase = new RepositorioBase<Prueba>();
           p.PruebaID = 1;
            Assert.AreEqual(true, repositorioBase.Eliminar(p.PruebaID));
        }
    }
}