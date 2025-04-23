using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO9
{
    class MaiorIgual
    {
        int n1;
        int n2;

        public MaiorIgual()
        {
            this.n1 = 0;
            this.n2 = 0;
        }

        public MaiorIgual(int x, int y)
        {
            this.n1 = x;
            this.n2 = y;
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

        public int indicarMaior()
        {
            if (this.n1 == this.n2)
            {
                return 0;
            }
            else
            {
                if (this.n1 > this.n2)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
