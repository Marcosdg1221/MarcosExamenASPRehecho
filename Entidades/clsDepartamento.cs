using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class clsDepartamento
    {
        #region atributos
        private string nombreDepartamento;
        private int idDepartamento;
        #endregion
        #region propiedades
        public String NombreDepartamento
        {
            get { return nombreDepartamento; }
        }

        public int IdDepartamento
        {
            get { return idDepartamento; }
        }
        #endregion
        #region constructores
        public clsDepartamento()
        {
        }
        public clsDepartamento(int id, string nombre)
        {
            this.idDepartamento = id;
            this.nombreDepartamento = nombre;
        }
        #endregion
    }
}