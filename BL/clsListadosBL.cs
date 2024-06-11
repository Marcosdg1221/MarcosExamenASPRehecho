using DAL;
using Entidades;

namespace BL
{
    public class clsListadosBL
    {

        /// <summary>
        /// Función estática que devuelve la lista departamentos de la base de datos de sql.
        /// </summary>
        /// <returns>La listaDepartamentos</returns>
        public static List<clsDepartamento> ObtenerDepartamentosBL()
        {
            List<clsDepartamento> listadoCompleto = clsListadosDAL.ObtenerListaDepartamentosDAL();
            return listadoCompleto;
        }

        /// <summary>
        /// Función estática que devuelve la lista de personas por el idDep pasada por parámetro
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns>ListaPersonas por IDDep</returns>
        public static List<clsPersona> ListaPersonasPorDepBL(int idDepartamento)
        {
            return clsListadosDAL.ListaPersonasPorDepDAL(idDepartamento);
        }

        /// <summary>
        /// Primero se comprueba que no son entre las 18:00 y las 08:00
        /// </summary>
        public static int BorrarPersonasBL(int IdDep)
        {
            //menor que diecisiete y mayor que 7, para que sea de 8 a más y de 18 a menos. (Si son las 8:00 a 17:59 aún cuenta)
            if (DateTime.Now.Hour < 18 && DateTime.Now.Hour > 7)
            {
                return -1; //Que significa que no se podrá borrar.
            }
            else
            {
                return PersonasHandler.BorrarPersonas(IdDep);
            }
        }
    }
}