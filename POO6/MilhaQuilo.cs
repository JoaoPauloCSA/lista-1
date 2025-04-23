using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO6
{
    class MilhaQuilo
    {
        double milhas;
        double resultado;

        public MilhaQuilo()
        {
            this.milhas = 0;
        }

        public MilhaQuilo(double x)
        {
            this.milhas = x;
        }

        public void setMilhas(double x)
        {
            this.milhas = x;
        }

        public double getMilhas()
        {
            return this.milhas;
        }

        public double getResultado()
        {
            return this.resultado;
        }

        public void calcular()
        {
            this.resultado = this.milhas * 1.852;
        }
    }
}
