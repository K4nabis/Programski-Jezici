namespace Delegati
{
    public class Program
    {
        #region Metode
        //delegat zahteva metode koje imaju povratnu vrednost int i 2 argumenta int
        public delegate int Operacija(int a, int b);
        public static int Saberi(int a, int b) => a + b;
        public static int Oduzmi(int a, int b) => a - b;

        //delegat zahteva metode koje nemaju povratnu vrednost i bez argumenta
        public delegate void Operacijica();
        public static void Overrided() => System.Console.WriteLine("Overrided.");
        public static void Obavesti() => System.Console.WriteLine("Delegat 1 pozvan.");
        public static void Obavesti2() => System.Console.WriteLine("Delegat 2 pozvan.");

        #endregion

        static void Main()
        {
            //ovde instsanciram delegat i delegat povezujem sa metodom
            Console.WriteLine("---Delegat s 2 parametra---");
            //na metodu ne idu zagrade Oduzmi()
            Operacija op = new Operacija(Oduzmi);
            Console.WriteLine("Oduzimanje: " + op(5, 7));

            //dodeljivanje metode delegatu 
            op = Saberi;
            Console.WriteLine("Sabiranje: " + op(5, 10));

            #region Dodavanje i oduzimanje metoda iz delegata

            Console.WriteLine("\n---Dodavanje---");
            //dodavanje metoda koje ce se izvrsiti na poziv delegata
            Operacijica operacija = new Operacijica(Obavesti);
            //Mogu da ih dodam jer je povratna vrednost kreiranog delegata void
            //A Metode takodje imaju pv void
            operacija += Obavesti2;
            operacija += Obavesti;
            //pozivanje delegata - Zove se 1,2,1
            operacija();

            //ako delegatu dodelim neku metodu a pre toga postoji "lista" metoda 
            //onda se lista ponistava
            operacija = Overrided;
            Console.WriteLine("\n---Overridovanje---");
            operacija();
            //ili ako zelim da obrisem listu
            operacija = null; //ako se sad pozove baca EXCEPTION
                              //operacija();
            Console.WriteLine("\n---Oduzimanje---");
            //Prvo dodam nekolko 
            operacija = Obavesti;
            operacija += Obavesti;
            operacija += Obavesti2;
            //oduzimanje metoda koje ce se izvrsiti na poziv delegata
            
            operacija -= Obavesti;
            operacija -= Obavesti;
            operacija();

            //ako sklonim sve metode iz "liste" delegata bacice NULL exception
            //da bi izbegao to radim proveru ako je prazan nece da izvrsi poziv
            operacija -= Obavesti2;
            if (operacija != null)
                operacija();

            operacija = Obavesti;

            #endregion

            #region Anonimna metoda i lambda izrazi

            //Anonimna metoda je kreiranje delegata bez kreiranje posebne metode
            //Ovo je korisno kada želiš da koristiš delegat samo na jednom mestu u kodu i ne planiraš ponovnu upotrebu metode.
            Operacijica anonimo = delegate {
                Console.WriteLine("\nOvo je anonimna metoda."); 
            };
            anonimo();

            //Sintaksa - (parameters) => expression. Kod se moze ispisati u 1 liniji koda
            //Lambda je dobar jer je sintaksa kratka da ne bi morao da pravis metodu za nesto sitno

            //Lambda izrazi:    Funk<>    Action<>, Predicate<>
            //Vracaju:         bilo sta     void       bool
            //Funk <razni broj parametara zivisi koliko ti treba>.  Zadnji parametar je tip povratne vrednosti.
            Func<int, int, int> proizvod = (a, b) => a * b; 
            Console.WriteLine("\nProizvod: " + proizvod(5, 5)); // Ispisuje 25

            Action<string> pozdrav = ime => Console.WriteLine("\nZdravo, " + ime);
            pozdrav("Ana"); // Ispisuje "Zdravo, Ana" - sa argumentom, ime je prenosni argument

            Action hello= () => Console.WriteLine("\nBez <> argumenta");
            hello(); //Ispisuje samo "Cao" - bez argumenta
            
            Predicate<int> jeParan = x => x % 2 == 0;
            Console.WriteLine("\n" + jeParan(4)); // Ispisuje "True"

            //VAZNO:
            //Razlika izmedju anonimne metode i lambda izraza je to sto:
            //  ANONIMNA koristi = delegate {...}
            //  LAMBDA   koristi = () => ... 
            #endregion

        }
    }
}