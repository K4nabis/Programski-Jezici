namespace zad10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Klasa.Metoda(1,2,3,4,5));
        }
    }
    class Klasa
    {
        public static int Metoda(params int[] numbers)
        {
            int zbir=0;
            foreach (int i in numbers)
                zbir += i * i;
            return zbir;
        }
    }

}
