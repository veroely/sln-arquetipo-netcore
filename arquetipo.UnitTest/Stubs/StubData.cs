using arquetipo.Domain.Dto.Solicitud;
using arquetipo.Entity.Models;
using System;

namespace arquetipo.UnitTest.Stubs
{
    public static class StubData
    {
        public static Solicitud solicitud1 = new Solicitud()
        {
            IdSolicitud = 1,
            IdCliente = 1,
            IdEjecutivo = 1,
            IdPatioVehicular = 1,
            IdVehiculo = 1,
            Cuotas = 1,
            PlazoMeses = 1,
            Entrada = 200,
            IdEstadoSolicitud = 1,
            FechaCreacion = DateTime.Today
        };
        public static Solicitud solicitudNUll = null;

        public static EstadoSolicitud solicitudRegistrada = new EstadoSolicitud() 
        { IdEstadoSolicitud = 1, Descripcion = "Registrada", EsActivo = true };

        public static EstadoSolicitud solicitudDespachada = new EstadoSolicitud()
        { IdEstadoSolicitud = 2, Descripcion = "Despachada", EsActivo = true };

        public static EstadoSolicitud solicitudCancelada = new EstadoSolicitud()
        { IdEstadoSolicitud = 3, Descripcion = "Cancelada", EsActivo = true };

        public static Solicitud solicitudMismoCliente = new Solicitud()
        {
            IdCliente = 1,
            IdPatioVehicular = 1,
            IdEjecutivo = 1,
            IdVehiculo = 1,
            Cuotas = 5,
            PlazoMeses = 10,
            Observacion = "Ninguna",
            Entrada = 455,
            IdEstadoSolicitud = 1,
            FechaCreacion = DateTime.Today
        };
        public static  Solicitud solicitud = new Solicitud()
         {
            IdCliente = 2,
            IdPatioVehicular = 1,
            IdEjecutivo = 1,
            IdVehiculo = 1,
            Cuotas = 12,
            PlazoMeses = 12,
            Observacion = "Ninguna",
            Entrada = 200,
            IdEstadoSolicitud = 1,
            FechaCreacion = DateTime.Today
        };

        public static Vehiculo vehiculo1 = new Vehiculo()
        {
            IdVehiculo = 1,
            IdMarcaVehicular = 1,
            Modelo = "",
            NumeroChasis = "",
            Placa = "",
            Tipo = "",
            Cilindraje = 5,
            Avaluo = 20000
        };

    }
}
