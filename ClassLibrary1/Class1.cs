using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        // si tratta della somma
        public static int Mistero1(int x , int y)
        {
            int prec;
            if (y == 0)
                return x;
            else
                prec = Mistero1(x, y - 1) + 1;
            return prec;
        }
        // si tratta della moltiplicazione
        public static int Mistero2(int x , int y)
        {
            if (y == 0)
                return 0;
            else
                return (Mistero1(x, Mistero2(x, y - 1))); 
        }
        public static int Mistero3(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return (Mistero2(x, Mistero3(x, y - 1)));
        }
        public static int Fattoriale (int n)
        {
            if (n == 0)
                return 1;
            return n * Fattoriale(n - 1);
        }
        // si tratta di divisione 
        public static string Mistero4 (long n)
        {
            Console.Write(n % 10);
            if (n / 10 != 0)
                return Mistero4(n / 10);
            else
                return "";
        }
        public static int Mistero5 (int n)
        {
            if (n == 0)
                return 0;
            else if (n== 1)
                return 1;
            return (Mistero5(n - 1) + Mistero5(n - 2));
        }
        public static int Mistero6 (int x ,int y)
        {
            if (x < 0)
                return Mistero6(x + y, y);
            else if (x < y)
                return x;
            else
                return Mistero6(x - y, y);
        }
        public static 
    }
}
