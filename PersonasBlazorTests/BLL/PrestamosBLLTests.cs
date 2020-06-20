using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonasBlazor.BLL;
using PersonasBlazor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonasBlazor.BLL.Tests
{
    [TestClass()]
    public class PrestamosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Prestamos prestamo = new Prestamos();
            prestamo.PersonaId = 1;
            prestamo.Concepto = "Prueba";
            prestamo.Fecha = DateTime.Now;
            prestamo.Monto = 100;

            paso = PrestamosBLL.Guardar(prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Prestamos prestamo = new Prestamos();
            prestamo.PrestamoId = 1;
            prestamo.PersonaId = 2;
            prestamo.Concepto = "Prueba Modificada";
            prestamo.Fecha = DateTime.Now;
            prestamo.Monto = 100;

            paso = PrestamosBLL.Modificar(prestamo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = PrestamosBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Prestamos prestamo = PrestamosBLL.Buscar(1);
            Assert.IsNotNull(prestamo);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Prestamos> lista = PrestamosBLL.GetList();
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = PrestamosBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }
    }
}