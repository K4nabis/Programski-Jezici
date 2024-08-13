namespace Jun_II_2023
{
    /*
    Razlika između struct i class je u tome što su strukture vrednosni tipovi, čija je podrazumevana 
    vrednost numerička vrednost (na primer, 0 za celobrojne tipove, 0.0f za decimalne), 
    dok su klase referentni tipovi, čija je podrazumevana vrednost null, tj. nemaju 
    inicijalizovanu instancu dok se eksplicitno ne kreiraju.
    */
    struct KompleksniBroj_A
    {
        public float Realni { get; set; }
        public float Imaginarni { get; set; }
        public override string ToString()
        {
            return Realni + " + j" + Imaginarni;
        }
    }
    class KompleksniBroj_B
    {
        public float Realni { get; set; }
        public float Imaginarni { get; set; }
        public override string ToString()
        {
            return Realni + " + j" + Imaginarni;
        }
        public KompleksniBroj_B(float re, float im)
        {
            this.Realni = re;
            this.Imaginarni = im;
        }
    }


}
