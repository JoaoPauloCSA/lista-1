using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO11
{
    class IMC
    {
        double altura;
        double peso;
        double Imc;

        public IMC()
        {
            this.altura = 0;
            this.peso = 0;
        }

        public IMC(double x, double y)
        {
            this.altura = x;
            this.peso = y;
        }

        public void setAltura(double x)
        {
            this.altura = x;
        }

        public void setPeso(double x)
        {
            this.peso = x;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public double getPeso()
        {
            return this.peso;
        }

        public double getImc()
        {
            return this.Imc;
        }

        public void calcular()
        {
            this.Imc = this.peso / Math.Pow(this.altura,2);
        }
    }
}
