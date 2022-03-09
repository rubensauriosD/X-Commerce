using System;
using System.Collections.Generic;
using Commerce.Entidades;

namespace Commerce.Servicios
{
    public static class FacturaServicio
    {
        private static string NombreArchivo = $@"{Environment.CurrentDirectory}/Facturas.txt";
        private static string DetalleArchivo = $@"{Environment.CurrentDirectory}/DetalleFacturas.txt";
        
        public static List<Factura> Facturas = new List<Factura>();
        public static List<DetalleFactura> DetalleFacturas = new List<DetalleFactura>();

        // 1 Solo Obtener datos que accede a los Archivos
        public static void ObtenerDatosDelArchivo()
        {

        }

        //public static List<FacturaDto> Obtener()
        //{
        //    return new List<FacturaDto>();
        //}
    }
}
