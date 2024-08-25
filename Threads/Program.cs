using Threads;
using System.Threading;
using System.Runtime.CompilerServices;

namespace Threads
{
    public class Program
    {
        //Locker koji zakljucava metodu
        private readonly object kljuc = new object();
        static void Main()
        {
            string rec = "Rec! ";
            string novaRec = "Nova Rec! ";

            //Pravljenje preko lambde moze da se prosledi arg u metodu
            Thread myThread = new Thread(() => DoWork(rec));
            Thread noviThread = new Thread(() => DoWork(novaRec));

            //Ako se pravi ovako ne moze da ima arugmetni
            Thread tred = new Thread(BezArg);

            //Setovanje imena
            myThread.Name = "Tred_1 ";
            noviThread.Name = "Tred_2 ";
            tred.Name = "Tred random";

            //Startovanje
            myThread.Start();
            noviThread.Start();
            tred.Start();

            //S join main stoji na join liniju i ceka da se zavrsi Thread
            myThread.Join();
            noviThread.Join();
            Console.WriteLine("GG!!!");

            Console.WriteLine("NOVI PROGRAM SEMAOFRI!!!\n");



        }
#region SEMAFOR
        //Kreira semafor sa početnim i maksimalnim brojem dozvola.
        //Razlika izmedju C# i jave je sto u javi se moze dinamicki menjati broj dozvola
        //Dok u C# samo pri instanciranju semafora
        //U javi acquire() i release() u C# ovo dole
        private readonly Semaphore _semaphore = new Semaphore(2, 2, "Semafor_1");

        // TODO: 
        public void PristupiResursu()
        {
            try
            {   //Niti zahteva dozvolu. Ako nema dostupnih dozvola, nit će čekati.
                _semaphore.WaitOne();
                Console.WriteLine("Pristup resursu.");
            }
            finally
            {   //Oslobađa dozvolu i omogućava drugim nitima da nastave sa radom.
                _semaphore.Release();
                Console.WriteLine("Oslobadjanje dozvole.");
            }
        }

        public void PrintS()
        {
            try
            {
                _semaphore.WaitOne();
            }
            finally { _semaphore.Release(); }
        }

#endregion SEMAFOR

#region METODE PRVOG DELA
        public void Sinc()
        {
            float a = 0; float b = 0;
            lock (kljuc)  //kod u locku je siguran od multitredinga
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Radi 1 " + Thread.CurrentThread.Name + " " + a + " sec");
                    Thread.Sleep(1000);
                    a += 1.0f;
                }
            }
            Console.WriteLine(Thread.CurrentThread.Name + " zavrsio petlju 1");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Radi 2 " + Thread.CurrentThread.Name + " " + b + " sec");
                Thread.Sleep(1500);
                b += 1.5f;
            }
            Console.WriteLine(Thread.CurrentThread.Name + " zavrsio 2!");
        }
        static void DoWork(string data)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(data);
                Thread.Sleep(1000);
            }

        }
        static void BezArg()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
        }
        #endregion METODE PRVOG DELA
    }
}