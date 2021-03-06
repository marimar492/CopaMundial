﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CopaMundialAPI.Servicios.Traductores.Apuestas;
using CopaMundialAPI.Servicios.Traductores.Jugadores;
using CopaMundialAPI.Servicios.Traductores.Logros;
using CopaMundialAPI.Servicios.Traductores.Ciudades;
using CopaMundialAPI.Servicios.Traductores.Usuarios;
using CopaMundialAPI.Servicios.Traductores.Equipos;
using CopaMundialAPI.Servicios.Traductores.Estadios;
using CopaMundialAPI.Servicios.Traductores.Partidos;

namespace CopaMundialAPI.Servicios.Traductores.Fabrica
{
    public class FabricaTraductor
    {
        public static TraductorUsuarioConfiguracion CrearTraductorUsuarioConfiguracion()

        {
            return new TraductorUsuarioConfiguracion();
        }

        public static TraductorUsuario CrearTraductorUsuario()

        {
            return new TraductorUsuario();
        }

        public static TraductorApuestaCantidad CrearTraductorApuestaCantidad() 
        {
            return new TraductorApuestaCantidad();
        }

        public static TraductorApuestaJugador CrearTraductorApuestaJugador()
        {
            return new TraductorApuestaJugador();
        }

        public static TraductorApuestaVOF CrearTraductorApuestaVoF()
        {
            return new TraductorApuestaVOF();
        }

        public static TraductorApuestaEquipo CrearTraductorApuestaEquipo()
        {
            return new TraductorApuestaEquipo();
        }

        public static TraductorJugador CrearTraductorJugador()
        {
            return new TraductorJugador();
        }

        public static TraductorListarProximosPartidos CrearTraductorListarProximosPartidos()
        {
            return new TraductorListarProximosPartidos();
        }

        /// <summary>
        /// Metodo con el cual se instancia un objeto de tipo TraductorCiudad
        /// </summary>
        /// <returns></returns>
        public static TraductorCiudad CrearTraductorCiudad ( )
        {
            return new TraductorCiudad ( );
        }
	/*	public static TraductorCiudad2 CrearTraductorCiudad2()
		{
			return new TraductorCiudad2();
		}
		*/
		public static TraductorCiudadNombre CrearTraductorCiudadNombre()
		{
			return new TraductorCiudadNombre();
		}

		public static TraductorCiudadID CrearTraductorCiudadID()
		{
			return new TraductorCiudadID();
		}
       
        public static TraductorMostrarLogrosPartido CrearTraductorMostrarLogrosPartidos()
        {
            return new TraductorMostrarLogrosPartido();
        }

        public static TraductorJugadorId CrearTraductorJugadorId()
        {
            return new TraductorJugadorId();
        }

        public static TraductorObtenerJugadores CrearTraductorObtenerJugadores()
        {
            return new TraductorObtenerJugadores();
        }

        public static TraductorLogroCantidad CrearTraductorLogroCantidad()
        {
            return new TraductorLogroCantidad();
        }

        public static TraductorLogroJugador CrearTraductorLogroJugador()
        {
            return new TraductorLogroJugador();
        }

        public static TraductorLogroEquipo CrearTraductorLogroEquipo()
        {
            return new TraductorLogroEquipo();
        }

        public static TraductorLogroVF CrearTraductorLogroVF()
        {
            return new TraductorLogroVF();
        }

        public static TraductorLogroPartidoId CrearTraductorLogroPartidoId()
        {
            return new TraductorLogroPartidoId();
        }

        public static TraductorListaPartidosLogros CrearTraductorListaPartidosLogros()
        {
            return new TraductorListaPartidosLogros();
        }

        public static TraductorLogroCantidadResultado CrearTraductorLogroCantidadResultado()
        {
            return new TraductorLogroCantidadResultado();
        }

        public static TraductorLogroJugadorResultado CrearTraductorLogroJugadorResultado()
        {
            return new TraductorLogroJugadorResultado();
        }

        public static TraductorLogroEquipoResultado CrearTraductorLogroEquipoResultado()
        {
            return new TraductorLogroEquipoResultado();
        }

        public static TraductorLogroVFResultado CrearTraductorLogroVFResultado()
        {
            return new TraductorLogroVFResultado();
        }

        public static TraductorUsuarioId CrearTraductorUsuarioId()
        {
            return new TraductorUsuarioId();
        }

        public static TraductorUsuarioRegistrar CrearTraductorUsuarioRegistrar()
        {
            return new TraductorUsuarioRegistrar();
        }

        public static TraductorModificarJugador CrearTraductorModificarJugador()
        {
            return new TraductorModificarJugador();
        }

        public static TraductorEquipo CrearTraductorEquipo()
        {
            return new TraductorEquipo();
        }

        public static TraductorEstadio CrearTraductorEstadio()
        {
            return new TraductorEstadio();
        }

        public static TraductorAlineacion CrearTraductorAlineacion()
        {
            return new TraductorAlineacion();
        }

        public static TraductorAlineacionActualizar CrearTraductorAlineacionActualizar()
        {
            return new TraductorAlineacionActualizar();
        }

        public static TraductorAlineacionNuevo CrearTraductorAlineacionNuevo()
        {
            return new TraductorAlineacionNuevo();
        }

        public static TraductorPartidoSoloId CrearTraductorPartidoSoloId()
        {
            return new TraductorPartidoSoloId();
        }

        public static TraductorAlineacionSoloId CrearTraductorAlineacionSoloId()
        {
            return new TraductorAlineacionSoloId();
        }

        public static TraductorPartido CrearTraductorPartido()
        {
            return new TraductorPartido();
        }

        public static TraductorPartidoActualizar CrearTraductorPartidoActualizar()
        {
            return new TraductorPartidoActualizar();
        }

        public static TraductorPartidoFecha CrearTraductorPartidoFecha()
        {
            return new TraductorPartidoFecha();
        }

        public static TraductorPartidoNuevo CrearTraductorPartidoNuevo()
        {
            return new TraductorPartidoNuevo();
        }

        public static TraductorPartidoReducido CrearTraductorPartidoReducido()
        {
            return new TraductorPartidoReducido();
        }
    }
}