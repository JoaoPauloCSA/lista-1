using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO12
{
    class FTriangulo
    {
        int a;
        int b;
        int c;

        public FTriangulo()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }

        public FTriangulo(int x, int y, int z)
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

        public string triangular()
        {
            if (this.a + this.b < this.c)
            {
                return "Não";
            }
            if (this.a + this.c < this.b)
            {
                return "Não";
            }
            if (this.b + this.c < this.a)
            {
                return "Não";
            }

            //tipo de triangulo
            if (this.a == this.b && this.a == this.c) //equilátero
            {
                return "equilátero";
            }
            if (this.a == this.b || b == this.c || a == this.c) //isosceles
            {
                return "isosceles";
            }
            else //escaleno
            {
                return "escaleno";
            }
        }
    }
}
