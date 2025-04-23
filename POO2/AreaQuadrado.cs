using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    class AreaQuadrado
    {
        private double aresta;
        private double resultado;

        public AreaQuadrado()
        {
            this.aresta = 0;
        }

        public AreaQuadrado(double x)
        {
            this.aresta = x;
        }

        public void setAresta(double x)
        {
            this.aresta = x;
        }

        public double getAresta()
        {
            return this.aresta;
        }

        public double getResultado()
        {
            return this.resultado;
        }

        public void calcular()
        {
            this.resultado = Math.Pow(this.aresta, 2);
        }
    }
}
