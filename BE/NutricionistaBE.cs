using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class NutricionistaBE
    {
        private string antiguedad;
        private DateTime fecha_ingreso;
        private string mail;
        private DateTime turno;

        public NutricionistaBE(string antiguedad, DateTime fecha_ingreso, string mail, DateTime turno)
        {
            this.antiguedad = antiguedad;
            this.fecha_ingreso = fecha_ingreso;
            this.mail = mail;
            this.turno = turno;
        }

        public string Antiguedad
        {
            get { return antiguedad; }
            set { antiguedad = value; }
        }

        public DateTime Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        
        public DateTime Turno
        {
            get { return turno; }
            set { turno = value; }
        }   
    }   

}
