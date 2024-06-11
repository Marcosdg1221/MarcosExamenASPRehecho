using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonasHandler
    {
        /// <summary>
        /// Función estática que borra las personas que se encuentran en el departamento con su ID
        /// </summary>
        /// <param name="IdDepartamento"></param>
        public static int BorrarPersonas(int IdDepartamento)
        {
            int filasAfectadas = 0;
            using (SqlConnection connection = new SqlConnection(clsConexion.CadenaConexion()))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                // Por algún motivo, con el StringBuilder me da error, con este otro no, así que usaré este.
                command.CommandText = "DELETE FROM Personas WHERE IdDepartamento = @IdDepartamento";

                // Agregar el parámetro
                command.Parameters.AddWithValue("@IdDepartamento", IdDepartamento);

                connection.Open();
                filasAfectadas = command.ExecuteNonQuery();
                connection.Close(); 
            }
            return filasAfectadas;
        }
    }
}
