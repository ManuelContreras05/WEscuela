using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace wEstudiantes
{
    public class Estudiante : Persona
    {
        private double note;
        public double Note { get { return note; } set { note = value; } }

        public string Study()
        {
            return Note + " Esta Estudianto ";
        }
    }
}
