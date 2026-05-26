using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2T2
{
    internal class ArbolBBP
    {
        private NodoP Primero { get; set; }
        public ArbolBBP()
        {
            Primero = null;
        }
        public void Agregar(int v)
        {
            Primero = AgregarRecursivo(Primero, v);
        }
        private NodoP AgregarRecursivo(NodoP r, int valor)
        {
            if (r == null)
            {
                return new NodoP(new Empleado { Codigo = valor });
            }
            else if (valor < r.Dato)
            {
                r.Izq = AgregarRecursivo(r.Izq, valor);
            }
            else if (valor > r.Dato)
            {
                r.Der = AgregarRecursivo(r.Der, valor);
            }
            return r;
        }

        public void RecorrerInOrden()
        {
            RecorrerInOrdenRec(Primero);
        }
        public void RecorrerInOrdenRec(NodoP r)
        {
            if (r != null)
            {
                RecorrerInOrdenRec(r.Izq);
                Console.Write(r.Valor + " ");
                RecorrerInOrdenRec(r.Der);
            }
        }

        public bool Buscar(int v)
        {
            return true;
        }

        public void MuestraInCodigo()
        {
            MuestraInCodigo(Primero);
        }

        private void MuestraInCodigo(NodoP r)
        {
            if (r != null)
            {
                MuestraInCodigo(r.Izq);
                Console.WriteLine(r.Valor.Codigo);
                MuestraInCodigo(r.Der);
            }
        }

        public void MuestraPosAntiguedad()
        {
            MuestraPosAntiguedad(Primero);
        }

        public void MuestraPosAntiguedad(NodoP r)
        {
            if (r != null)
            {
                MuestraPosAntiguedad(r.Izq);
                Console.WriteLine(r.Valor.Antiguedad);
                MuestraPosAntiguedad(r.Der);
            }
        }

        public void MayoresA(int antiguedad)
        {
            MayoresA(Primero, antiguedad);
        }

        public void MayoresA(NodoP r, int antiguedad)
        {
            if (r != null)
            {
                MayoresA(r.Izq, antiguedad);
                if (r.Valor.Antiguedad > antiguedad)
                {
                    Console.WriteLine(r.Valor.Nombre);
                }
                MayoresA(r.Der, antiguedad);
            }
        }

        public string Penultimo()
        {
            return Penultimo(Primero);
        }

        public string Penultimo(NodoP r)
        {
            if (r == null || (r.Izq == null && r.Der == null))
            {
                return null;
            }
            if ((r.Izq != null && r.Izq.Izq == null && r.Izq.Der == null) ||
                (r.Der != null && r.Der.Izq == null && r.Der.Der == null))
            {
                return r.Valor.Nombre;
            }
            string izqPenultimo = Penultimo(r.Izq);
            if (izqPenultimo != null)
            {
                return izqPenultimo;
            }
            return Penultimo(r.Der);
        }
    }
}