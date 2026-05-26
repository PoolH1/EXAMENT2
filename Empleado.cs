using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2T2
{
    internal class Empleado
    {
        private int codigo;

        private string nombre;

        private int antiguedad;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
    }
}
