using System;
using System.Collections.Generic;
using Commerce.Entidades;

namespace Commerce.Servicios
{
    public static class ClienteServicio
    {
        private static string NombreArchivo = $@"{Environment.CurrentDirectory}/Clientes.txt";
        
        // Lista de Clientes para el sistema
        public static List<Cliente> Clientes = new List<Cliente>();
        
        public static void ObtenerDatosDelArchivo()
        {

        }

        public static void Add(Cliente cliente)
        {
            // Se agrega al Archivo

            // Se agrega a la Lista Estatica
        }

        /// <summary>
        /// Metodo para Obtener una lista de segun un criterio de busqueda
        /// </summary>
        /// <param name="cadenaBuscar">Cadena a buscar en: Codigo, Apellido, Nombre, Dni</param>
        /// <returns></returns>
        public static List<Cliente> Obtener(string cadenaBuscar)
        {
            // Esto se debe cambiar por el resultado devuelto
            return new List<Cliente>();
        }

        public static Cliente Obtener(long id)
        {
            // Esto se debe cambiar por el resultado devuelto
            return new Cliente();
        }
    }
}
