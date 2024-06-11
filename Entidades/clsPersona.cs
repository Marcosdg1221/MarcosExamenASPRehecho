using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsPersona
    {
        #region atributos
        int id;
        string nombre;
        string apellidos;
        DateTime fechaNac;
        string tlf;
        string direccion;
        string foto;
        int idDept;
        #endregion

        #region propiedades
        public int Id
        {
            get { return id; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public string Apellidos
        {
            get { return apellidos; }
        }
        public DateTime FechaNac
        {
            get { return fechaNac; }
        }
        public string Tlf
        {
            get { return tlf; }
        }
        public string Direccion
        {
            get { return direccion; }
        }
        public string Foto
        {
            get { return foto; }
        }
        public int IdDept
        {
            get { return idDept; }
            set { idDept = value; }
        }
        #endregion

        #region constructores
        public clsPersona() { }
        public clsPersona(int id, string nombre, string apellidos, DateTime fechaNac, string tlf, string direccion, string foto, int idDept)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.tlf = tlf;
            this.direccion = direccion;
            this.foto = foto;
            this.idDept = idDept;
        }
        public clsPersona(clsPersona persona)
        {
            this.id = persona.id;
            this.nombre = persona.nombre;
            this.apellidos = persona.apellidos;
            this.fechaNac = persona.fechaNac;
            this.tlf = persona.tlf;
            this.direccion = persona.direccion;
            this.foto = persona.foto;
            this.idDept = persona.idDept;
        }
        #endregion

    }
}