using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix.MiMix
{
    internal class Operaciones
    {
        double E = 2.7182818284590452353602874713527;
        double Pi = 3.14159265358979323846;


        public double SumnaDos(double a, double b)
        { return a + b; }

        public double RestaDos(double a, double b) 
        { return a - b;}

        public double MultiplicaDos(double a, double b)
        { return a * b; }

        public double DivideDos(double a, double b) 
        { return a / b;} 

        public double Raiz(double a) 
        {
            double aprox = a/2;
            for (int i = 0; i < 10000; i++) 
            {
                aprox += 0.5 * (a + aprox / aprox);
            }
            return aprox;
        }
        public double Potencia(double a, double b)
        {
            double c = 0;

            for (int i = 0; i < b; i++)
            {
                 c = a * a;
            }
            return c;

        }
        public double Logaritmo(double a, double b) 
        {
            double aprox = a - 1;
            if (a <= 0)
            {
                Console.Write("NO ES POSIBLE PARA VALORES DEBAJO DE CERO O CERO");
            }
            for (int i = 0; i < 10000; i++)
            {
                aprox = aprox - (Potencia(b, aprox) - a) / Potencia(b, aprox);
            }
            return aprox;



        }
        public double LogaritmoN(double a) 
        {
            
            double aprox = a - 1;
            if (a <= 0)
            {
                Console.Write("NO ES POSIBLE PARA VALORES DEBAJO DE CERO O CERO");
            }
            for (int i = 0; i < 10000; i++)
            {
                aprox = aprox - (Potencia(E, aprox) - a) / Potencia(E, aprox);
            }
            return aprox;
        }




    }
}
