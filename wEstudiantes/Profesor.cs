using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace wEstudiantes
{
    public class Profesor : Persona
    {
        private double salary;
        public double Salary { get { return salary; } set { salary = value; } }
        public string Learn()
        {
            return salary + " Enseñar ";
        }
    }
}
