using System;
using System.Threading;
using System.Threading.Channels;

namespace Random
{
    public class Program
    {
        public static void Main()
        {

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
            public static void fib1(int n)
            {
                int k1 = 1;
                int k2 = 0;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(k1);
                    k1 = k1 + k2;
                    k2 = k1 - k2;
                }
            }
        }
        public abstract class Apstraktna
        {
            int a;
            public abstract void DoStuff();
            public virtual void NeAbs() { }
            public void Obicna() { }

        }
        public class NeAbstract : Apstraktna, Interface1
        {
            public override void DoStuff()
            {
                throw new NotImplementedException();
            }
            public void MethodFromInterface()
            {
                Console.WriteLine("Nasledjena"); ;
            }
            public override void NeAbs()
            {
                base.NeAbs();
            }
        }

#region NestoOInterfejsu...
        public class NasledjivanjeInterfejsa : Interface1
        {
            public void MethodFromInterface() { Console.WriteLine("Nasledjena"); }
            /*
            * Postoji jos jedna metoda u Interfejsu koja ima default telo {}
            Ne moze da se pozove jos ta jedna metoda preko ni ali moze ako se
            instancira Objekat preko Interfejsa
            
            * U main ubaci
            NasledjivanjeInterfejsa ni = new NasledjivanjeInterfejsa();
            ni.MethodFromInterface();
            Interface1 face = new NasledjivanjeInterfejsa();
            face.MethodFromInterfaceWithBody();
            */
        }
#endregion NestoOInterfejsu...

#region Nedovrsen zadatak
        abstract class GeometrijskoTelo
        {
            public abstract double Zapremina { get; }
        }
        class Kvadar : GeometrijskoTelo
        {
            private double a, b, c;
            public override double Zapremina { get { return a * b * c; } }

            public static bool operator <(Kvadar levi, GeometrijskoTelo desni) { return true; }
            public static bool operator >(Kvadar levi, GeometrijskoTelo desni) { return true; }

        }

        class Valjak : GeometrijskoTelo
        {
            private double r, h; // polupreénik i visina
            public override double Zapremina
            {
                get { return r * r * 3.14f * h; }
            }

            public static bool operator <(Valjak levi, GeometrijskoTelo desni)
            { return true; }

            public static bool operator >(Valjak levi, GeometrijskoTelo desni)
            { return true; }
        }
        #endregion Nedovrsen zadatak

#region EXCEPTION
        public class MyException : Exception
        {
            public MyException() { }
            public MyException(string mess) : base(mess) { }
        }

        /*Ovo u main: 
          try 
            {
                Ex exception = new Ex("Oopsiee");
            }
            catch (MyException e)
            {
                Console.WriteLine(e);
            }
        */
        class Ex
        {
            public Ex(string greska) => throw new MyException(greska);
        }
        #endregion EXCEPTION

    }
}