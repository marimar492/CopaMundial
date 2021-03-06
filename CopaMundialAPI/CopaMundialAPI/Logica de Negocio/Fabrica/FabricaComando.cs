﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CopaMundialAPI.Comun.Entidades;
using CopaMundialAPI.Logica_de_Negocio.Comando.Apuestas;
using CopaMundialAPI.Logica_de_Negocio.Comando.Ciudades;
using CopaMundialAPI.Logica_de_Negocio.Comando.Logros;
using CopaMundialAPI.Logica_de_Negocio.Comando;
using CopaMundialAPI.Logica_de_Negocio.Comando.Jugadores;
using CopaMundialAPI.Logica_de_Negocio.Comando.Usuarios;
using CopaMundialAPI.Logica_de_Negocio.Comando.Partidos;
using CopaMundialAPI.Logica_de_Negocio.Comando.EquipoEstatico;
using CopaMundialAPI.Logica_de_Negocio.Comando.EstadioEstatico;

namespace CopaMundialAPI.Logica_de_Negocio.Fabrica
{
    public static class FabricaComando
    {
        public static ComandoActualizarCorreo CrearComandoActualizarCorreo(Entidad usuario)
        {
            return new ComandoActualizarCorreo(usuario);
        }

        public static ComandoActualizarPassword CrearComandoActualizarPassword(Entidad usuario)
        {
            return new ComandoActualizarPassword(usuario);
        }

        public static ComandoActualizarUsuario CrearComandoActualizarUsuario(Entidad usuario)

        {
            return new ComandoActualizarUsuario(usuario);
        }

        public static ComandoAgregarUsuarioAdministrador CrearComandoAgregarUsuarioAdministrador(Entidad usuario)

        {
            return new ComandoAgregarUsuarioAdministrador(usuario);
        }


        public static ComandoObtenerUsuarioActivo CrearComandoObtenerUsuarioActivo()

        {
            return new ComandoObtenerUsuarioActivo();
        }

        public static ComandoObtenerUsuarioNoActivo CrearComandoObtenerUsuarioNoActivo()

        {
            return new ComandoObtenerUsuarioNoActivo();
        }

        public static ComandoObtenerUsuarioDatos CrearComandoObtenerUsuarioDatos(Entidad usuario)

        {
            return new ComandoObtenerUsuarioDatos (usuario);
        }

        public static ComandoVerificarClaveUsuario CrearComandoVerificarClaveUsuario(Entidad usuario)

        {
            return new ComandoVerificarClaveUsuario(usuario);
        }

        public static ComandoVerificarCorreoExiste CrearComandoVerificarCorreoExiste(Entidad usuario)

        {
            return new ComandoVerificarCorreoExiste(usuario);
        }

        public static ComandoAgregarCiudad CrearComandoAgregarCiudad ( Entidad ciudad )
        {
            return new ComandoAgregarCiudad ( ciudad );
        }

		public static ComandoObtenerCiudad CrearComandoObtenerCiudad (int id)
		{
			return new ComandoObtenerCiudad(id);
		}

		public static ComandoActualizarCiudad CrearComandoActualizarCiudad(Entidad ciudad)
		{
			return new ComandoActualizarCiudad(ciudad);
		}

		public static ComandoEliminarCiudad CrearComandoEliminarCiudad(Entidad ciudad)
		{
			return new ComandoEliminarCiudad(ciudad);
		}

		public static ComandoListarCiudades CrearComandoListarCiudades()
		{
			return new ComandoListarCiudades();
		}
		public static ComandoObtenerCiudadPorNombre CrearComandoObtenerCiudadPorNombre(Entidad ciudad)
		{
			return new ComandoObtenerCiudadPorNombre(ciudad);
		}

		public static ComandoObtenerCiudadTrue CrearComandoObtenerCiudadesHabilitadas()
		{
			return new ComandoObtenerCiudadTrue();
		}

		public static ComandoAgregarApuestaVOF CrearComandoAgregarApuestaVoF(Entidad apuesta)
        {
            return new ComandoAgregarApuestaVOF(apuesta);
        }

        public static ComandoObtenerApuestasVoFEnCurso CrearComandoObtenerApuestasVoFEnCurso(Entidad usuario)
        {
            return new ComandoObtenerApuestasVoFEnCurso(usuario);
        }

        public static ComandoAgregarJugador CrearComandoAgregarJugador(Entidad jugador)
        {
            return new ComandoAgregarJugador(jugador);
        }

        public static ComandoModificarJugador CrearComandoModificarJugador(Entidad jugador)
        {
            return new ComandoModificarJugador(jugador);
        }

        public static ComandoActivarJugador CrearComandoActivarJugador(Entidad jugador)
        {
            return new ComandoActivarJugador(jugador);
        }

        public static ComandoDesactivarJugador CrearComandoDesactivarJugador(Entidad jugador)
        {
            return new ComandoDesactivarJugador(jugador);
        }

        public static ComandoObtenerJugadores CrearComandoObtenerJugadores()
        {
            return new ComandoObtenerJugadores();
        }

        public static ComandoObtenerProximosPartidos CrearComandoObtenerProximosPartidos()
        {
            return new ComandoObtenerProximosPartidos();
        }

        /// <exception cref="ApuestaRepetidaException"></exception>
        public static ComandoVerificarApuestaVoFExiste CrearComandoVerificarApuestaVoFExiste(Entidad apuesta)
        {
            return new ComandoVerificarApuestaVoFExiste(apuesta);
        }

        /// <exception cref="ApuestaRepetidaException"></exception>
        public static ComandoVerificarApuestaCantidadExiste CrearComandoVerificarApuestaCantidadExiste(Entidad apuesta)
        {
            return new ComandoVerificarApuestaCantidadExiste(apuesta);
        }

        public static ComandoAgregarApuestaCantidad CrearComandoAgregarApuestaCantidad(Entidad apuesta)
        {
            return new ComandoAgregarApuestaCantidad(apuesta);
        }

        /// <exception cref="ApuestaRepetidaException"></exception>
        public static ComandoVerificarApuestaJugadorExiste CrearComandoVerificaApuestaJugadorExiste(Entidad apuesta)
        {
            return new ComandoVerificarApuestaJugadorExiste(apuesta);
        }

        public static ComandoAgregarApuestaJugador CrearComandoAgregarApuestaJugador(Entidad apuesta)
        {
            return new ComandoAgregarApuestaJugador(apuesta);
        }

        public static ComandoAgregarApuestaEquipo CrearComandoAgregarApuestaEquipo(Entidad apuesta)
        {
            return new ComandoAgregarApuestaEquipo(apuesta);
        }

        /// <exception cref="ApuestaRepetidaException"></exception>
        public static ComandoVerificarApuestaEquipoExiste CrearComandoVerificaApuestaEquipoExiste(Entidad apuesta)
        {
            return new ComandoVerificarApuestaEquipoExiste(apuesta);
        }

       public static ComandoAgregarLogroCantidad CrearComandoAgregarLogroCantidad(Entidad logroPartido)
        {
            return new ComandoAgregarLogroCantidad(logroPartido);
        }

        public static ComandoObtenerLogrosCantidadPendientes CrearComandoObtenerLogrosCantidadPendientes(Entidad partido)
        {
            return new ComandoObtenerLogrosCantidadPendientes(partido);
        }

        public static ComandoAgregarLogroJugador CrearComandoAgregarLogroJugador(Entidad logroPartido)
        {
            return new ComandoAgregarLogroJugador(logroPartido);
        }

        public static ComandoObtenerLogrosJugadorPendientes CrearComandoObtenerLogrosJugadorPendientes(Entidad partido)
        {
            return new ComandoObtenerLogrosJugadorPendientes(partido);
        }

        public static ComandoAgregarLogroEquipo CrearComandoAgregarLogroEquipo(Entidad logroPartido)
        {
            return new ComandoAgregarLogroEquipo(logroPartido);
        }

        public static ComandoObtenerLogrosEquipoPendientes CrearComandoObtenerLogrosEquipoPendientes(Entidad partido)
        {
            return new ComandoObtenerLogrosEquipoPendientes(partido);
        }

        public static ComandoAgregarLogroVF CrearComandoAgregarLogroVF(Entidad partido)
        {
            return new ComandoAgregarLogroVF(partido);
        }

        public static ComandoObtenerLogrosVFPendientes CrearComandoObtenerLogrosVFPendientes(Entidad partido)
        {
            return new ComandoObtenerLogrosVFPendientes(partido);
        }

        public static ComandoObtenerLogroPartidosFinalizados CrearComandoObtenerLogroPartidosFinalizados()
        {
            return new ComandoObtenerLogroPartidosFinalizados();
        }

        public static ComandoObtenerProximosLogrosPartidos CrearComandoObtenerProximosLogrosPartidos()
        {
            return new ComandoObtenerProximosLogrosPartidos();
        }

        public static ComandoObtenerLogroPartidoPorId CrearComandoObtenerLogroPartidoPorId(Entidad partido)
        {
            return new ComandoObtenerLogroPartidoPorId(partido);
        }     

        public static ComandoAsignarResultadoLogroCantidad CrearComandoAsignarResultadoLogroCantidad(Entidad logroCantidad)
        {
            return new ComandoAsignarResultadoLogroCantidad(logroCantidad);
        }

        public static ComandoAsignarResultadoLogroEquipo CrearComandoAsignarResultadoLogroEquipo(Entidad logroEquipo)
        {
            return new ComandoAsignarResultadoLogroEquipo(logroEquipo);
        }

        public static ComandoAsignarResultadoLogroJugador CrearComandoAsignarResultadoLogroJugador(Entidad logroJugador)
        {
            return new ComandoAsignarResultadoLogroJugador(logroJugador);
        }

        public static ComandoAsignarResultadoLogroVF CrearComandoAsignarResultadoLogroVF(Entidad logroVF)
        {
            return new ComandoAsignarResultadoLogroVF(logroVF);
        }

        public static ComandoObtenerLogrosCantidadResultados CrearComandoObtenerLogrosCantidadResultados(Entidad partido)
        {
            return new ComandoObtenerLogrosCantidadResultados(partido);
        }

        public static ComandoObtenerLogrosJugadorResultados CrearComandoObtenerLogrosJugadorResultados(Entidad partido)
        {
            return new ComandoObtenerLogrosJugadorResultados(partido);
        }

        public static ComandoObtenerLogrosEquipoResultados CrearComandoObtenerLogrosEquipoResultados(Entidad partido)
        {
            return new ComandoObtenerLogrosEquipoResultados(partido);
        }

        public static ComandoObtenerLogrosVFResultados CrearComandoObtenerLogrosVFResultados(Entidad partido)
        {
            return new ComandoObtenerLogrosVFResultados(partido);
        }

        public static ComandoObtenerApuestasCantidadEnCurso CrearComandoObtenerApuestasCantidadEnCurso(Entidad usuario)
        {
            return new ComandoObtenerApuestasCantidadEnCurso(usuario);
        }

        public static ComandoObtenerApuestasJugadorEnCurso CrearComandoObtenerApuestasJugadorEnCurso(Entidad usuario)
        {
            return new ComandoObtenerApuestasJugadorEnCurso(usuario);
        }

        public static ComandoObtenerApuestasEquipoEnCurso CrearComandoObtenerApuestasEquipoEnCurso(Entidad usuario)
        {
            return new ComandoObtenerApuestasEquipoEnCurso(usuario);
        }

        /// <exception cref="ApuestaInvalidaException"></exception>
        public static ComandoVerificarApuestaVoFValida CrearComandoVerificarApuestaVoFValida(Entidad apuesta)
        {
            return new ComandoVerificarApuestaVoFValida(apuesta);
        }

        /// <exception cref="ApuestaInvalidaException"></exception>
        public static ComandoVerificarApuestaCantidadValida CrearComandoVerificarApuestaCantidadValida(Entidad apuesta)
        {
            return new ComandoVerificarApuestaCantidadValida(apuesta);
        }

        /// <exception cref="ApuestaInvalidaException"></exception>
        public static ComandoVerificarApuestaJugadorValida CrearComandoVerificarApuestaJugadorValida(Entidad apuesta)
        {
            return new ComandoVerificarApuestaJugadorValida(apuesta);
        }

        /// <exception cref="ApuestaInvalidaException"></exception>
        public static ComandoVerificarApuestaEquipoValida CrearComandoVerificarApuestaEquipoValida(Entidad apuesta)
        {
            return new ComandoVerificarApuestaEquipoValida(apuesta);
        }

        public static ComandoActualizarApuestaVoF CrearComandoActualizarApuestaVoF(Entidad apuesta)
        {
            return new ComandoActualizarApuestaVoF(apuesta);
        }

        public static ComandoActualizarApuestaCantidad CrearComandoActualizarApuestaCantidad(Entidad apuesta)
        {
            return new ComandoActualizarApuestaCantidad(apuesta);
        }

        public static ComandoActualizarApuestaJugador CrearComandoActualizarApuestaJugador(Entidad apuesta)
        {
            return new ComandoActualizarApuestaJugador(apuesta);
        }

        public static ComandoActualizarApuestaEquipo CrearComandoActualizarApuestaEquipo(Entidad apuesta)
        {
            return new ComandoActualizarApuestaEquipo(apuesta);
        }

        public static ComandoEliminarApuestaVOF CrearComandoEliminarApuestaVoF(Entidad apuesta)
        {
            return new ComandoEliminarApuestaVOF(apuesta);
        }

        public static ComandoEliminarApuestaCantidad CrearComandoEliminarApuestaCantidad(Entidad apuesta)
        {
            return new ComandoEliminarApuestaCantidad(apuesta);
        }

        public static ComandoEliminarApuestaJugador CrearComandoEliminarApuestaJugador(Entidad apuesta)
        {
            return new ComandoEliminarApuestaJugador(apuesta);
        }

        public static ComandoEliminarApuestaEquipo CrearComandoEliminarApuestaEquipo(Entidad apuesta)
        {
            return new ComandoEliminarApuestaEquipo(apuesta);
        }

        public static ComandoObtenerApuestasVoFFinalizadas CrearComandoObtenerApuestasVoFFinalizadas(Entidad usuario)
        {
            return new ComandoObtenerApuestasVoFFinalizadas(usuario);
        }

        public static ComandoObtenerApuestasCantidadFinalizadas CrearComandoObtenerApuestasCantidadFinalizadas(Entidad usuario)
        {
            return new ComandoObtenerApuestasCantidadFinalizadas(usuario);
        }

        public static ComandoObtenerApuestasJugadorFinalizadas CrearComandoObtenerApuestasJugadorFinalizadas(Entidad usuario)
        {
            return new ComandoObtenerApuestasJugadorFinalizadas(usuario);
        }

        public static ComandoObtenerApuestasEquipoFinalizadas CrearComandoObtenerApuestasEquipoFinalizadas(Entidad usuario)
        {
            return new ComandoObtenerApuestasEquipoFinalizadas(usuario);
        }

        public static ComandoObtenerJugadoresActivo CrearComandoObtenerJugadoresActivo()
        {
            return new ComandoObtenerJugadoresActivo();
        }

        public static ComandoObtenerJugadoresInactivo CrearComandoObtenerJugadoresInactivo()
        {
            return new ComandoObtenerJugadoresInactivo();
        }
        public static ComandoFinalizarApuestasCantidad CrearComandoFinalizarApuestasCantidad()
        {
            return new ComandoFinalizarApuestasCantidad();
        }

        public static ComandoFinalizarApuestasVoF CrearComandoFinalizarApuestasVoF()
        {
            return new ComandoFinalizarApuestasVoF();
        }

        public static ComandoFinalizarApuestasJugador CrearComandoFinalizarApuestasJugador()
        {
            return new ComandoFinalizarApuestasJugador();
        }

        public static ComandoFinalizarApuestasEquipo CrearComandoFinalizarApuestasEquipo()
        {
            return new ComandoFinalizarApuestasEquipo();
        }

        public static ComandoFinalizarApuestas CrearComandoFinalizarApuestas()
        {
            return new ComandoFinalizarApuestas();
        }

        public static ComandoAgregarUsuario CrearComandoAgregarUsuario(Entidad usuario)
        {
            return new ComandoAgregarUsuario(usuario);
        }

        public static ComandoObtenerJugadorId CrearComandoObtenerJugadorId(Entidad jugador)
        {
            return new ComandoObtenerJugadorId(jugador);
        }

        public static ComandoValidarCapitan CrearComandoValidarCapitan(Entidad entidad)
        {
            return new ComandoValidarCapitan(entidad);
        }

        public static ComandoValidarMaximoJugadores CrearComandoValidarMaximoJugadores(Entidad entidad)
        {
            return new ComandoValidarMaximoJugadores(entidad);
        }

        public static ComandoValidarAlineacion CrearComandoValidarAlineacion(Entidad entidad)
        {
            return new ComandoValidarAlineacion(entidad);
        }

        public static ComandoActualizarAlineacion CrearComandoActualizarAlineacion(Entidad entidad)
        {
            return new ComandoActualizarAlineacion(entidad);
        }

        public static ComandoActualizarPartido CrearComandoActualizarPartido(Entidad entidad)
        {
            return new ComandoActualizarPartido(entidad);
        }

        public static ComandoAlineacionPorPartido CrearComandoAlineacionPorPartido(Entidad entidad)
        {
            return new ComandoAlineacionPorPartido(entidad);
        }

        public static ComandoCrearAlineacion CrearComandoCrearAlineacion(Entidad entidad)
        {
            return new ComandoCrearAlineacion(entidad);
        }

        public static ComandoCrearPartido CrearComandoCrearPartido(Entidad entidad)
        {
            return new ComandoCrearPartido(entidad);
        }

        public static ComandoEliminarAlineacion CrearComandoEliminarAlineacion(Entidad entidad)
        {
            return new ComandoEliminarAlineacion(entidad);
        }

        public static ComandoObtenerEquipoEstatico CrearComandoObtenerEquipoEstatico(Entidad entidad)
        {
            return new ComandoObtenerEquipoEstatico(entidad);
        }

        public static ComandoObtenerEstadioEstatico CrearComandoObtenerEstadioEstatico(Entidad entidad)
        {
            return new ComandoObtenerEstadioEstatico(entidad);
        }

        public static ComandoObtenerListaPartidosPorFecha CrearComandoObtenerListaPartidosPorFecha(Entidad entidad)
        {
            return new ComandoObtenerListaPartidosPorFecha(entidad);
        }

        public static ComandoObtenerPartido CrearComandoObtenerPartido(Entidad entidad)
        {
            return new ComandoObtenerPartido(entidad);
        }

        public static ComandoObtenerPartidos CrearComandoObtenerPartidos()
        {
            return new ComandoObtenerPartidos();
        }

        public static ComandoObtenerTodosLosEquipos CrearComandoObtenerTodosLosEquipos()
        {
            return new ComandoObtenerTodosLosEquipos();
        }

        public static ComandoObtenerTodosLosEstadios CrearComandoObtenerTodosLosEstadios()
        {
            return new ComandoObtenerTodosLosEstadios();
        }

    }
}
