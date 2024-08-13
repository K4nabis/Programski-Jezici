using System;

namespace Zadatak
{
    public class Exx : Exception
    {
        public Exx() { }
        public Exx(string a) { Console.WriteLine(a); }
    }
    public class Stavka
    {
        float cena;
        public static bool operator >(Stavka s1, Stavka s2)
        {
            return s1.cena < s2.cena;
        }
        public static bool operator <(Stavka s1, Stavka s2)
        {
            return true;
        }
        public float Cena { get => cena; set => cena = value; }
        public Stavka() { }

        public Stavka(float cena)
        {
            this.cena = cena;
        }
    }
    public class Korpa
    {
        Stavka[] nizStavki;
        int trenutniBroj;
        public Korpa()
        {
            nizStavki = new Stavka[1];
            trenutniBroj = 0;
        }
        public void Dodaj(Stavka stavka)
        {
            try
            {
                nizStavki[trenutniBroj++] = stavka;
            }
            catch (Exception)
            {
                throw new Exx("Prepunjeno\n");
            }
        }
        public float UkupnaCenaKorpe()
        {
            float ukupnaCena = 0;

            if (nizStavki.Length > trenutniBroj)
            {
                for (int i = 0; i < trenutniBroj; i++)
                {
                    ukupnaCena += nizStavki[i].Cena;
                }
            }
            else
                throw new Exx("Nece stati");
                return ukupnaCena;
        }
        public static Korpa operator +(Korpa k, Stavka stavka)
        {
            k.Dodaj(stavka);
            return k;
        }
    }
}