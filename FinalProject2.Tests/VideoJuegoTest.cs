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
    public class VideoJuegoTest
    {
        [TestMethod]
        public void Guardar()
        {
            RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();
            VideoJuego VideoJuego = new VideoJuego();
            bool paso = false;

            VideoJuego.VideoJuegoId = 1;
            VideoJuego.FechaRegistro = DateTime.Now;
            VideoJuego.Titulo = "Zelda 1";
            VideoJuego.Plataforma = "ps3";
            VideoJuego.Genero = "aventura";
            VideoJuego.Descripcion = "aventurar y hacer cosas";
            VideoJuego.CantidadEjemplares = 2;

            paso = repositorio.Guardar(VideoJuego);
            Assert.AreEqual(true, paso);
        }
        [TestMethod]
        public void Buscar()
        {
            int id = 1;
            RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();
            VideoJuego VideoJuego = new VideoJuego();
            VideoJuego = repositorio.Buscar(id);
            Assert.IsNotNull(VideoJuego);
        }

        [TestMethod]
        public void Modificar()
        {
            var VideoJuego = BuscarM();
            RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();

            bool paso = false;
            VideoJuego.Titulo = "zelda 2";
            paso = repositorio.Modificar(VideoJuego);
            Assert.AreEqual(true, paso);
        }

        public VideoJuego BuscarM()
        {
            int id = 2;
            RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();
            VideoJuego VideoJuego = new VideoJuego();
            VideoJuego = repositorio.Buscar(id);
            return VideoJuego;
        }
        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();
            List<VideoJuego> lista = new List<VideoJuego>();
            Expression<Func<VideoJuego, bool>> resultado = p => true;
            lista = repositorio.GetList(resultado);
            Assert.IsNotNull(lista);
        }
        [TestMethod]
        public void Eliminar()
        {
            RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();
            int id = 1;
            bool paso = false;
            paso = repositorio.Eliminar(id);
            Assert.AreEqual(true, paso);
        }
    }
}