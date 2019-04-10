using BLL;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//****Recordar que el nombre de mi instancia no es .sqlexpress, por lo que deberia cambiarlo en el conectionstring

//Para asegurar que algunos metodos funcionen(Principalmente el buscar), buscar uno que no sea el eliminado. 
//o correrlos uno por uno en de forma descendente
//asegurrarse que los id sean los correctos en sql management studio




namespace FinalProject2.Tests
{
    [TestClass]
    public class MiembroTest
    {
        [TestMethod]
        public void Guardar()
        {
            RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();
            Miembro miembro = new Miembro();
            bool paso = false;

            miembro.MiembroId = 1;
            miembro.FechaRegistro = DateTime.Now;
            miembro.Nombre = "Jose";
            miembro.Telefono = "8093860441";
            miembro.Cedula = "11111111111";
            miembro.Direccion = "urb almanzar";

            paso = repositorio.Guardar(miembro);
            Assert.AreEqual(true, paso);
        }
        [TestMethod]
        public void Buscar()
        {
            int id = 2;
            RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();
            Miembro miembro = new Miembro();
            miembro = repositorio.Buscar(id);
            Assert.IsNotNull(miembro);
        }

        [TestMethod]
        public void Modificar()
        {
            var miembro = BuscarM();
            RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();

            bool paso = false;
            miembro.Nombre = "Michael";
            paso = repositorio.Modificar(miembro);
            Assert.AreEqual(true, paso);
        }

        public Miembro BuscarM()
        {
            int id = 2;
            RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();
            Miembro miembro = new Miembro();
            miembro = repositorio.Buscar(id);
            return miembro;
        }
        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();
            List<Miembro> lista = new List<Miembro>();
            Expression<Func<Miembro, bool>> resultado = p => true;
            lista = repositorio.GetList(resultado);
            Assert.IsNotNull(lista);
        }
        [TestMethod]
        public void Eliminar()
        {
            RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();
            int id = 1;
            bool paso = false;
            paso = repositorio.Eliminar(id);
            Assert.AreEqual(true, paso);
        }
    }
}