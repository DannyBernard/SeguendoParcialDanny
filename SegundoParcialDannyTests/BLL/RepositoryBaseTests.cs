using Microsoft.VisualStudio.TestTools.UnitTesting;
using SegundoParcialDanny.BLL;
using SegundoParcialDanny.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SegundoParcialDanny.BLL.Tests
{
    [TestClass()]
    public class RepositoryBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Vendedor vendedor = new Vendedor();
            vendedor.IDVendedor = 1;
            vendedor.Nombre = "willians";
            vendedor.Retecion = 15;
            vendedor.Sueldo = 2100;
            vendedor.Total = 12021;
            RepositoryBase<Vendedor> repository;
            repository = new RepositoryBase<Vendedor>();
            Assert.IsTrue(repository.Guardar(vendedor));
        }
    }
}