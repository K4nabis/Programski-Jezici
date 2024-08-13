using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak;
using Zadatak2;

namespace PrviPY
{
  /*
   internal class Zadatak
    {
        static void Main()
        {
            Korpa k = new Korpa();
            Stavka s1 = new Stavka(42);
            Stavka s2 = new Stavka(66);

            try
            {
                if (s1 > s2)
                    k = k + s2;
                else
                    k = k + s1;
                k.Dodaj(s1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine(s1.Cena);
            Console.WriteLine(s2.Cena);
            try
            {
                Console.WriteLine(k.UkupnaCenaKorpe());
            }
            catch (Exception ex) { }
        }
    }
  */
    internal class Zadatak2
    {
        public static void Main()
        {
            Generator generator = new Generator();
            Pretplatnik1 p1 = new Pretplatnik1();  
            Pretplatnik2 p2 = new Pretplatnik2();
            p1.Pretplata(generator);
            p2.Pretplata(generator);
            generator.prikaziPoruku("pozdrav");
        }
    }
}
