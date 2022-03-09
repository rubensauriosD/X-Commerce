using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commerce.Entidades;

namespace Commerce.Servicios
{
    public static class StockServicio
    {
        private static string NombreArchivo = $@"{Environment.CurrentDirectory}/Stocks.txt";

        public static List<Stock> Stocks = new List<Stock>();

        public static void ObtenerDatosDelArchivo()
        {

        }

        public static void Add(Stock stock)
        {
            // Se agrega al Archivo

            // Se agrega a la Lista Estatica
        }

        public static decimal ObtenerPorId(long productoId)
        {
            return 0m;
        }
    }
}
