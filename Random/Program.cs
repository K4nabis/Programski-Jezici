using System.ComponentModel;
using System.Reflection.Emit;

namespace Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ovo je isto tj int je skracenica od ovo
            int br1 = 0;
            System.Int32 br2 = 0;


            Console.WriteLine(Klasa.fib(3));

        }
    }

    enum Dani       //Enumeracija
    {
        PONEDELJAK,
        UTORAK
    }
    struct Skruktura    //User-defined value type
    {       
        float Realni;
        float Imaginarni;
        public Skruktura()
        {
             Realni = 0;
             Imaginarni = 0;
        }
    }
    public class Klasa
    {
        //static radi isto kao i u Javu
        public static int staticBroj = 0;
        public int neStaticBroj = 0;

        public static void StaticMetoda()
        {
            //static metoda nema pristup ne static atributima
            staticBroj = 5;
            //neStaticBroj = 6; 
        }

        public static int fib(int n)
        {
            if (n < 2)
                return 1;
            else
                return fib(n - 1) + fib(n - 2);
        }

        public static void Metoda1()
        {
           
        }

    }
}
