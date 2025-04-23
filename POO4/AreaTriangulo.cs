using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO4
{
    class AreaTriangulo
    {
        double basin;
        double altura;
        double resultado;

        public AreaTriangulo()
        {
            this.basin = 0;
            this.altura = 0;
        }

        public AreaTriangulo(double x, double y)
        {
            this.basin = x;
            this.altura = x;
        }

        #region setget
        public void setBasin(double x)
        {
            this.basin = x;
        }

        public void setAltura(double x)
        {
            this.altura = x;
        }

        public double getBasin()
        {
            return this.basin;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public double getResultado()
        {
            return this.resultado;
        }
        #endregion

        public void calcular()
        {
            this.resultado = (this.basin * this.altura) / 2;
        }
    }
}
