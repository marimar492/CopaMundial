﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopaMundialAPI.Comun.Entidades;
using CopaMundialAPI.Comun.Entidades.Fabrica;
using CopaMundialAPI.Comun.Excepciones;
using CopaMundialAPI.Fuente_de_Datos.DAO;
using CopaMundialAPI.Fuente_de_Datos.Fabrica;
using CopaMundialAPI.Logica_de_Negocio.Comando;
using CopaMundialAPI.Logica_de_Negocio.Fabrica;
using CopaMundialAPI.Servicios.DTO.Logros;
using CopaMundialAPI.Servicios.Fabrica;
using CopaMundialAPI.Servicios.Traductores.Logros;
using CopaMundialAPI.Servicios.Traductores.Fabrica;
using CopaMundialAPI.Presentacion.Controllers;
using NUnit.Framework;
using System.Net.Http;
using System.Web.Http;
using System.Net;


namespace PruebasCopaMundialAPI.Modulo_7
{
    [TestFixture]
    public class PruebasLogroCantidad
    {
        
        private DAO dao;
        private Comando comando;
        private Entidad respuesta;
        private List<Entidad> _respuestas;
        private LogrosController controller;

        [SetUp]
        public void SetUp()
        {
            dao = FabricaDAO.CrearDAOLogroCantidad();
            dao.Conectar();
            controller = new LogrosController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

        }


        /// <summary>
        /// Metodo que prueba el resultado de exito
        /// del dao de Agregar logrocantidad
        /// </summary>
        [Test]
        public void PruebaDaoLogroCantidadAgregar()
        {
            
            LogroCantidad logro = FabricaEntidades.CrearLogroCantidad();
            Partido partido = FabricaEntidades.CrearPartido(); 
            logro.Partido = partido;
            logro.Partido.Id = 14; //cambiar por 1
            logro.IdTipo = TipoLogro.cantidad;
            logro.Logro = "Logro Prueba Agregar";
            

            ((DAOLogroCantidad)dao).Agregar(logro);
            respuesta = FabricaEntidades.CrearLogroCantidad();

            respuesta = ((DAOLogroCantidad)dao).ObtenerLogroPorId(logro);
    
            Assert.IsNotNull(respuesta);
        }

        /// <summary>
        /// Metodo que prueba el resultado de exito del 
        /// comando logroCantidadAgregar
        /// </summary>
        [Test]
        public void PruebaComandoLogroCantidadAgregar()
        {

            LogroCantidad logro = FabricaEntidades.CrearLogroCantidad();
            Partido partido = FabricaEntidades.CrearPartido();

            logro.Partido = partido;
            logro.Partido.Id = 14; //cambiar a 1
            logro.IdTipo = TipoLogro.cantidad;
            logro.Logro = "Logro cantidad Prueba Comando agregar";

            comando = FabricaComando.CrearComandoAgregarLogroCantidad(logro);
            comando.Ejecutar();
            respuesta = comando.GetEntidad();
            Assert.IsNotNull(respuesta);

        }

        /// <summary>
        /// Metodo que prueba la traduccion de una entidad 
        /// a un dtoLogroCantidad
        /// </summary>
        [Test]
        public void PruebaTraductorLogroCantidadDto()
        {
            TraductorLogroCantidad traductor = FabricaTraductor.CrearTraductorLogroCantidad();
            LogroCantidad logro = FabricaEntidades.CrearLogroCantidad();
            DTOLogroCantidad dtoLogro = FabricaDTO.CrearDTOLogroCantidad();

            Partido partido = FabricaEntidades.CrearPartido();
            logro.Partido = partido;
            logro.Partido.Id = 1;
            logro.IdTipo = TipoLogro.cantidad;
            logro.Logro = "Logro Prueba Traductor";

            dtoLogro = traductor.CrearDto(logro);

            Assert.AreEqual(1, dtoLogro.IdPartido);

        }

        /// <summary>
        /// Metodo que prueba la traduccion de un dtoLogroCantidad
        /// a una entidad logroCantidad
        /// </summary>
        [Test]
        public void PruebaTraductorLogroCantidadEntidad()
        {
            TraductorLogroCantidad traductor = FabricaTraductor.CrearTraductorLogroCantidad();
            LogroCantidad logro = FabricaEntidades.CrearLogroCantidad();
            DTOLogroCantidad dtoLogro = FabricaDTO.CrearDTOLogroCantidad();

            dtoLogro.IdPartido = 1;
            dtoLogro.LogroCantidad = "Prueba de dto a entidad";
            dtoLogro.TipoLogro = (int)TipoLogro.cantidad;

            logro = (LogroCantidad)traductor.CrearEntidad(dtoLogro);

            Assert.AreEqual(1, logro.Partido.Id);

        }

        /// <summary>
        /// Metodo que prueba la respuesta exitosa de
        ///del metodo agregarLogrocantidad del 
        ///LogroCotroller
        /// </summary>
        [Test]
        public void PruebaControllerAgregarLogroCantidad()
        {
            DTOLogroCantidad dtoLogro = FabricaDTO.CrearDTOLogroCantidad();
            dtoLogro.IdPartido = 14; //cambiar a 1
            dtoLogro.LogroCantidad = "Prueba controller Agregar logro cantidad";
            dtoLogro.TipoLogro = (int)TipoLogro.cantidad;

            Assert.AreEqual(HttpStatusCode.OK, controller.AgregarLogroCantidad(dtoLogro).StatusCode);

        }

        /// <summary>
        /// Metodo que prueba el resultado de exito 
        /// del dao ObtenerLogrosPendientes
        /// </summary>
        [Test]
        public void PruebaDaoObtenerLogrosCantidadPendientes()
        {

            Partido partido = FabricaEntidades.CrearPartido();
            partido.Id = 14; //cambiar por 1
 
            _respuestas = ((DAOLogroCantidad)dao).ObtenerLogrosPendientes(partido);
            Assert.IsNotNull(_respuestas);
        }


        /// <summary>
        /// Metodo que prueba el resultado de la
        /// excepcion LogrosPendientesNoExisteException
        /// en el Dao
        /// </summary>
        [Test]
        public void PruebaDaoObtenerLogrosCantidadPendientesException()
        {

            Partido partido = FabricaEntidades.CrearPartido();
            partido.Id = 15; //cambiar numero

            Assert.Throws<LogrosPendientesNoExisteException>(() => ((DAOLogroCantidad)dao).ObtenerLogrosPendientes(partido));
        }

        /// <summary>
        /// Metodo que prueba el resultado de exito del 
        /// comando ObtenerLogrosCantidadPendientes
        /// </summary>
        [Test]
        public void PruebaComandoObtenerLogrosCantidadPendientes()
        {
            Partido partido = FabricaEntidades.CrearPartido();

            partido.Id = 14; //cambiar a 1

            comando = FabricaComando.CrearComandoObtenerLogrosCantidadPendientes(partido);
            comando.Ejecutar();
            _respuestas = comando.GetEntidades();
            Assert.AreNotEqual(0, _respuestas.Count);

        }

        /// <summary>
        /// Metodo que prueba el resultado de la
        /// excepcion LogrosPendientesNoExisteException en el
        /// comando
        /// </summary>
        [Test]
        public void PruebaCmdObtenerLogrosCantidadPendientesException()
        {

            Partido partido = FabricaEntidades.CrearPartido();
            partido.Id = 15; //cambiar numero

            comando = FabricaComando.CrearComandoObtenerLogrosCantidadPendientes(partido);
            Assert.Throws<LogrosPendientesNoExisteException>(() => comando.Ejecutar());
        }

        
        /// <summary>
        /// Metodo que prueba la respuesta exitosa del
        /// metodo ObtenerLogrosCantidadPendiente del 
        /// LogroController
        /// </summary>
        [Test]
        public void PruebaControllerObtenerLogrosCantidadPendiente()
        {
            DTOLogroPartidoId dtoLogroPartidoId = FabricaDTO.CrearDTOLogroPartidoId();
            dtoLogroPartidoId.IdPartido = 14;//Cambiar

            Assert.AreEqual(HttpStatusCode.OK, controller.ObtenerLogrosCantidadPendientes(dtoLogroPartidoId).StatusCode);
            
        }

        /// <summary>
        /// Metodo que prueba la excepcion Logros
        /// pendientes not found exception del metodo 
        /// ObtenerLogrosCantidadPendientes de
        /// LogrosController
        /// </summary>
        [Test]
        public void PruebaControllerObtenerLogrosCantidadPendienteExc()
        {
            DTOLogroPartidoId dtoLogroPartidoId = FabricaDTO.CrearDTOLogroPartidoId();
            dtoLogroPartidoId.IdPartido = 16;//Cambiar
             Assert.AreEqual(HttpStatusCode.InternalServerError, controller.ObtenerLogrosCantidadPendientes(dtoLogroPartidoId).StatusCode);

        }

        /// <summary>
        /// Metodo que prueba el resultado de exito de
        // ObtenerLogroPorId de DaoLogroCantidad
        /// </summary>
        [Test]
        public void PruebaDaoObtenerLogroPorId()
        {
            LogroCantidad logro = FabricaEntidades.CrearLogroCantidad();
            logro.Id = 3;//asegurar que este id sea de tipo cantidad
            respuesta = ((DAOLogroCantidad)dao).ObtenerLogroPorId(logro);
            Assert.IsNotNull(respuesta);

        }

        /// <summary>
        /// Metodo que prueba el resultado exitoso 
        /// de AsignarResultadoLogro en DaoLogroCantidad
        /// </summary>
        [Test]
        public void PruebaDaoAsignarResultadoLogro()
        {

            LogroCantidad logro = FabricaEntidades.CrearLogroCantidad();
            logro.Id = 4;
            logro.Cantidad = 5;
            ((DAOLogroCantidad)dao).AsignarResultadoLogro(logro);

            respuesta = ((DAOLogroCantidad)dao).ObtenerLogroPorId(logro);

            Assert.AreEqual(5,((LogroCantidad)respuesta).Cantidad);
        }

        /// <summary>
        /// Metodo que prueba el resultado de exito del comando
        /// AsignarResultadoLogroCantidad 
        /// </summary>
        [Test]
        public void PruebaCmdAsignarResultadoLogroCantidad()
        {

            LogroCantidad logro = FabricaEntidades.CrearLogroCantidad();
            logro.Id = 7;//cambiar
            logro.Cantidad = 8;

            comando = FabricaComando.CrearComandoAsignarResultadoLogroCantidad(logro);
            comando.Ejecutar();

            respuesta = comando.GetEntidad();
            Assert.IsNotNull(respuesta);

        }


        [TearDown]
        public void TearDown()
        {
            dao.Desconectar();
            dao = null;
            comando = null; 
            respuesta = null;
            _respuestas = null;
            
        }

    }
}
