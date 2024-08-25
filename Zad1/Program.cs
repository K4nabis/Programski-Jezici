namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    abstract class Student{
        private int brojIndexa;
        private string ime;
        private string prezime;

        public int BrojIndexa { get { return brojIndexa; } set { brojIndexa = value; } }
        public string Ime { get { return ime; } set { prezime = value; } }
        public string Prezime { get => prezime; set => prezime = value; }

        public Student(int b, string i, string p)
        {
            BrojIndexa=b;
            Ime=i;
            Prezime=p;
        }



        public override string ToString()
        {
            return $"{BrojIndexa}, {Ime}, {Prezime}";
        }
    }
}
