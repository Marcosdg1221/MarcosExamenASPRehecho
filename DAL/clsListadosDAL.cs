using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsListadosDAL
    {

        /// <summary>
        /// Consigue la lista de departamentos de la base de datos de sql.
        /// </summary>
        /// <returns>lista de departamentos</returns>
        public static List<clsDepartamento> ObtenerListaDepartamentosDAL()
        {
            List<clsDepartamento> lista = new List<clsDepartamento>();
            SqlConnection miConexion = new SqlConnection(clsConexion.CadenaConexion());
            SqlCommand miComando = new SqlCommand("SELECT * FROM departamentos", miConexion);
            SqlDataReader miLector;

            miConexion.Open();
            miLector = miComando.ExecuteReader();

            if (miLector.HasRows)
            {
                while (miLector.Read())
                {
                    clsDepartamento oDepartamento = new clsDepartamento(
                        (int)miLector["ID"],
                        (string)miLector["nombre"]
                    );

                    lista.Add(oDepartamento);
                }
            }

            miLector.Close();
            //Devuelvo la lista
            return lista;
        }

        /// <summary>
        /// Funcion estática que obtiene de la base de datos, mediante el uso de Where, una lista de personas con un idDepartamento pasado por parámetro (de la lista desplegable) y devuelve esa lista.
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns>Una lista de personas con idDep concreta</returns>
        public static List<clsPersona> ListaPersonasPorDepDAL(int idDepartamento)
        {
            List<clsPersona> listaPersonas = new List<clsPersona>();
            using (SqlConnection connection = new SqlConnection(clsConexion.CadenaConexion()))
            {
                string query = "SELECT * FROM Personas where IdDepartamento = @idDepartamento";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idDepartamento", idDepartamento);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Crear instancia de clsPersona usando el constructor con parámetros
                        clsPersona oPersona = new clsPersona(
                            (int)reader["ID"],
                            (string)reader["nombre"],
                            (string)reader["apellidos"],
                            (DateTime)reader["fechaNacimiento"],
                            (string)reader["Telefono"],
                            (string)reader["direccion"],
                            (string)reader["foto"],
                            (int)reader["IdDepartamento"]
                        );

                        listaPersonas.Add(oPersona);
                    }
                    
                }
                reader.Close();
                return listaPersonas;
            }
        }
    }
}
