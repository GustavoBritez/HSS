using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PersonaBE
    {
        private string contrasenia;
        private string nombre;

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }   
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
