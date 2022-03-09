using System;
using System.Collections.Generic;
using Commerce.Entidades;

namespace Commerce.Servicios
{
    public class CuentaCorrienteServicio
    {
        private static string NombreArchivo = $@"{Environment.CurrentDirectory}/CuentaCorrientes.txt";
        
        // Lista de Clientes para el sistema
        public static List<CuentaCorriente> CuentaCorrientes = new List<CuentaCorriente>();
    }
}
