using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO7
{
    class CotaDolar
    {
        double cotacao;
        double quantia;
        double resultado;

        public CotaDolar()
        {
            this.cotacao = 0;
            this.quantia = 0;
        }

        public CotaDolar(double x, double y)
        {
            this.cotacao = x;
            this.quantia = y;
        }

        public void setCotacao(double x)
        {
            this.cotacao = x;
        }

        public void setQuantia(double x)
        {
            this.quantia = x;
        }

        public double getCotacao()
        {
            return this.cotacao;
        }

        public double getQuantia()
        {
            return this.quantia;
        }

        public double getResultado()
        {
            return this.resultado;
        }

        public void calcular()
        {
            this.resultado = this.quantia * this.cotacao;
        }
    }
}
