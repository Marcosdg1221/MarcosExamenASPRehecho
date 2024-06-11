using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// La cadena de conexion a usar.
    /// </summary>
    public class clsConexion
    {
        public static string CadenaConexion()
        {
            return $"server=107-02\\SQLEXPRESS;database=personas;uid=SA;pwd=mitesoro;trustServerCertificate=true;";
        }
    }
}