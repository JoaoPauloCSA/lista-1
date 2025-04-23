using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO1
{
    class Area
    {
        private double basinha;
        private double altura;
        private double resultado;

        public Area()
        {
            this.basinha = 0;
            this.altura = 0;
        }

        public Area(double x, double y)
        {
            this.basinha = x;
            this.altura = y;
        }

        #region getset
        public void setBasinha(double x)
        {
            this.basinha = x;
        }

        public void setAltura(double x)
        {
            this.altura = x; ;
        }

        public double getBasinha()
        {
            return this.basinha;
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
            this.resultado = this.basinha * this.altura;
        }
    }
}
