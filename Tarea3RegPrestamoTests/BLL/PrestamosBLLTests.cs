using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tarea3RegPrestamo.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using Tarea3RegPrestamo.Models;

namespace Tarea3RegPrestamo.BLL.Tests
{
    [TestClass()]
    public class PrestamosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Prestamos prestamos = new Prestamos();
            prestamos.PersonaId = 10;
            prestamos.FechaPrestamo = DateTime.Now;
            prestamos.PersonaId = 1;
            prestamos.Monto = 500;
            paso = PrestamosBLL.Guardar(prestamos);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ExisteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetEstudianteTest()
        {
            Assert.Fail();
        }
    }
}