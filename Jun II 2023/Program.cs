namespace Jun_II_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Zadatak 10.A
            //Struct
            Console.WriteLine("\n-----------Zadatak  A-----------");
            KompleksniBroj_A[] niz = new KompleksniBroj_A[4];
            for (int i = 0; i < niz.Length; i++)
            {
                niz[i].Realni = niz[i].Imaginarni = i;
            }
            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }
            #endregion

            #region Zadatak 10.B
            //Class
            Console.WriteLine("\n-----------Zadatak  B-----------\n" + "Ne radi");

            //Ne radi zato sto nema napravljenih objekata svaki je null i dobijam Exception
            //da bi ovo radilo u 1. for petlji je potrebno da se naprave objekti

            KompleksniBroj_B[] array = new KompleksniBroj_B[4];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new KompleksniBroj_B (i, i);     //original bez ovog
                array[i].Realni = array[i].Imaginarni = i;
            }
            for (int i = 0;i < array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
            #endregion
            #region Zadatak 11

            /*
             U ovom zadatku se pi i date nece promeniti zato sto se salju KOPIJE vrednosti 
            dok se kod klase salje objekat i zato se Re i Im menjaju tj povecavaju za 1
            nzm da li je greska u zadatku ali kad bi se date poslao i kao referenca opet se 
            ne bi povecalo zato sto treba date = date.AddDays(1) tad bi se povecao dan

            Ako bi hteo da pi i date posaljem kao reference morao bih u funkciji da izmenim
            sa ref ili out (razlika na dnu koda)
             */

            Console.WriteLine("\n-----------Zadatak 11-----------");
            double pi = 3.14;
            DateTime date = DateTime.Today;
            KompleksniBroj_B kompleksni = new KompleksniBroj_B(1.0f, 0.0f);

            //Po referenci
            //Inkrement(ref pi, ref date, kompleksni);
            Inkrement(pi, date, kompleksni);

            Console.WriteLine(pi);
            Console.WriteLine(date);
            //date = date.AddDays(1);
            //Console.WriteLine(date);
            Console.WriteLine(kompleksni);
        }

        //Po referenci 
        //private static void Inkrement(ref double pi,ref DateTime date, KompleksniBroj_B komp) 
        private static void Inkrement(double pi, DateTime date, KompleksniBroj_B komp)
        {
            pi++;
            date.AddDays(1);
            komp.Realni++;
            komp.Imaginarni++;
        }

        /*
        Takodje umesto ref moze da se koristi i out slicne su postoje samo male razlike 
        obe salju po referenci samo sto za prosledjivanje preko 
        REF - pre prosledjivanja mora biti inicijalizovano
        OUT - ne mora biti inicijalizovano ali se mora inic. pre nego se prosledi
         */
        #endregion
    }
}