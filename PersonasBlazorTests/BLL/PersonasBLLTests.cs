using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonasBlazor.BLL;
using PersonasBlazor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonasBlazor.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Personas persona = new Personas();
            persona.Nombre = "Estiven Padilla Santos";
            persona.Telefono = "809-290-1234";
            persona.Cedula = "402-1234567-1";
            persona.Direccion = "Bomba de Cenovi";
            persona.FechaNacimiento = DateTime.Now;
            
            paso = PersonasBLL.Guardar(persona);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;
            Personas persona = new Personas();
            persona.PersonaId = 1;
            persona.Nombre = "Estiven Padilla Santos";
            persona.Telefono = "809-290-1235";
            persona.Cedula = "402-1234567-1";
            persona.Direccion = "Bomba de Cenovi";
            persona.FechaNacimiento = DateTime.Now;

            paso = PersonasBLL.Modificar(persona);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = PersonasBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Personas persona = PersonasBLL.Buscar(1);
            Assert.IsNotNull(persona);
        }

        [TestMethod()]
        public void GetListTest()
        {
            List<Personas> lista = PersonasBLL.GetList();
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            paso = PersonasBLL.Existe(1);
            Assert.AreEqual(paso, true);
        }
    }
}