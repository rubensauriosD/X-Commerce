using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commerce.Entidades;

namespace Commerce.Servicios
{
    public static class ProductoServicio
    {
        private static string NombreArchivo = $@"{Environment.CurrentDirectory}/Productos.txt";
        
        public static List<Producto> Productos = new List<Producto>();
        
        public static void ObtenerDatosDelArchivo()
        {

        }

        public static void Add(Producto producto)
        {
            // Se agrega al Archivo

            // Se agrega a la Lista Estatica
        }

        public static List<Producto> Obtener(string cadenaBuscar)
        {
            return null;
        }

        public static Producto Obtener(long id)
        {
            return null;
        }
    }
}
