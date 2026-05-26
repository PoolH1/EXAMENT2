using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2T2
{
    internal class NodoP
    {
            public Empleado Valor { get; set; }
            public NodoP Izq { get; set; }
            public NodoP Der { get; set; }

            public int Dato { get; set; }

        public NodoP(Empleado valor)
            {
                this.Valor = valor;
                this.Izq = null;
                this.Der = null;
                 this.Dato = Dato;
            }

            public override string? ToString()
            {
                return Valor.ToString();
            }
        }
    }

