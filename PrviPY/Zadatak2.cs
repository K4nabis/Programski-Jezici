using System;

namespace Zadatak2
{
    public delegate void PrikaziPoruku(string poruka);

    class Generator
    {
        public PrikaziPoruku prikaziPoruku;
    }
    class Pretplatnik1
    {
        public void Stampa(string poruka)
        {
            Console.WriteLine("Pretplatnik1: " + poruka);
        }
        public void Pretplata(Generator generator)
        {
            generator.prikaziPoruku += Stampa;
            generator.prikaziPoruku("1 salje por");
        }
    }
    class Pretplatnik2
    {
        public void Stampa(string poruka)
        {
            Console.WriteLine("Pretplatnik2: " + poruka);
        }
        public void Pretplata(Generator gen)
        {

            gen.prikaziPoruku += Stampa;
            gen.prikaziPoruku("2 salje por.");
        }
    }
    
}