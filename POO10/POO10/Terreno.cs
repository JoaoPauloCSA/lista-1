using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO10
{
    class Terreno
    {
        double basin;
        double altura;
        double area;

        public Terreno()
        {
            this.basin = 0;
            this.altura = 0;
        }

        public Terreno(double x, double y)
        {
            this.basin = x;
            this.altura = y;
        }

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

        public double getArea()
        {
            return this.area;
        }

        public void calcular()
        {
            this.area = this.basin * this.altura;
        }
    }
}
