using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wEstudiantes
{
    public class Persona
    {
        private string name; 
        public string Name { get { return name; } set { name = value; } }

        public string Asistir()
        {
            return name + " Asiste a la clase ";
        }
    }
}
