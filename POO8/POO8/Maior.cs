using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO8
{
    class Maior
    {
        int n1;
        int n2;
        string ns="'não atribuido'";

        public Maior()
        {
            this.n1 = 0;
            this.n2 = 0;
            this.ns = "";
        }

        public Maior(int x, int y, string z)
        {
            this.n1 = x;
            this.n2 = y;
            this.ns = z;
        }

        public void setn1(int x)
        {
            this.n1 = x;
        }

        public void setn2(int x)
        {
            this.n2 = x;
        }

        public int getn1()
        {
            return this.n1;
        }

        public int getn2()
        {
            return this.n2;
        }
        public string getns()
        {
            return this.ns;
        }

        public int indicarMaior()
        {
            if(this.n1 > this.n2)
            {
                this.ns = "primeiro";
                return this.n1;
            }
            else
            {
                this.ns = "segundo";
                return this.n2;     
            }
        }
    }
}
