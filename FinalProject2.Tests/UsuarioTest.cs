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

//Para asegurar que algunos metodos funcionen(Principalmente el buscar y modificar), buscar uno que no sea el eliminado. 
//o correrlos uno por uno en de forma descendente
//asegurrarse que los id sean los correctos en sql management studio




namespace FinalProject2.Tests
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void Guardar()
        {
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
            Usuario usuario = new Usuario();
            bool paso = false;

            usuario.UsuarioId = 1;
            usuario.FechaRegistro = DateTime.Now;
            usuario.Nombre = "Jose";
            usuario.Telefono = "8093860441";
            usuario.Cedula = "11111111111";
            usuario.UserName = "Phoenix";
            usuario.Password = "123456";

            paso = repositorio.Guardar(usuario);
            Assert.AreEqual(true, paso);
        }
        [TestMethod]
        public void Buscar()
        {
            int id = 2;
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
            Usuario usuario = new Usuario();
            usuario = repositorio.Buscar(id);
            Assert.IsNotNull(usuario);
        }

        [TestMethod]
        public void Modificar()
        {
            var usuario = BuscarM();
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();

            bool paso = false;
            usuario.Nombre = "Michael";
            paso = repositorio.Modificar(usuario);
            Assert.AreEqual(true, paso);
        }

        public Usuario BuscarM()
        {
            int id = 1;
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
            Usuario usuario = new Usuario();
            usuario = repositorio.Buscar(id);
            return usuario;
        }
        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
            List<Usuario> lista = new List<Usuario>();
            Expression<Func<Usuario, bool>> resultado = p => true;
            lista = repositorio.GetList(resultado);
            Assert.IsNotNull(lista);
        }
        [TestMethod]
        public void Eliminar()
        {
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
            int id = 1;
            bool paso = false;
            paso = repositorio.Eliminar(id);
            Assert.AreEqual(true, paso);
        }
    }
}