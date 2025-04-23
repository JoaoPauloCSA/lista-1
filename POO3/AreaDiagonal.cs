using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    class AreaDiagonal
    {
        double diagonal;
        double resultado;

        public AreaDiagonal()
        {
            this.diagonal = 0;
        }

        public AreaDiagonal(double x)
        {
            this.diagonal = x;
        }

        public void setDiagonal(double x)
        {
            this.diagonal = x;
        }

        public double getDiagonal()
        {
            return this.diagonal;
        }

        public double getResultado()
        {
            return this.resultado;
        }

        public void calcular()
        {
            this.resultado = (Math.Pow(this.diagonal, 2)) / 2;
        }
    }
}
