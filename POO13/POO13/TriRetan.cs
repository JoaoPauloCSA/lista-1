using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO13
{
    class TriRetan
    {
        int a;
        int b;
        int c;

        public TriRetan()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }

        public TriRetan(int x, int y, int z)
        {
            this.a = x;
            this.b = y;
            this.c = z;
        }

        public void setA(int x)
        {
            this.a = x;
        }

        public void setB(int x)
        {
            this.b = x;
        }

        public void setC(int x)
        {
            this.c = x;
        }

        public int getA()
        {
            return this.a;
        }

        public int getB()
        {
            return this.b;
        }

        public int getC()
        {
            return this.c;
        }

        public int trianguloRetangular()
        {
            if (Math.Pow(this.a, 2) == Math.Pow(this.b, 2) + Math.Pow(this.c, 2))
            {
                return 1;
            }
            else
            {
                if (Math.Pow(this.b, 2) == Math.Pow(this.a, 2) + Math.Pow(this.c, 2))
                {
                    return 1;
                }
                else
                {
                    if (Math.Pow(this.c, 2) == Math.Pow(this.b, 2) + Math.Pow(this.a, 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
