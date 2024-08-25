namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Krug v = new Valjak(1, 1); //zove se krug const prvo pa valjak const pa ovi dole
            Console.WriteLine("Povrsina je "+ v.Povrsina);
            Console.WriteLine("Zapremina je "+ ((Valjak)v).Zapremina);
        }

    }
    internal class Krug
    {
        protected float r;
        public Krug(float r)
        {
            Console.Out.WriteLine(
                "Krug poluprecnika " + r);
            this.r = r;
        }
        public virtual float Povrsina
        {
            get { return 3.14f * r * r; } //Zove se ovo u main
        }

    }
    class Valjak : Krug
    {
        private float h;
        public Valjak(float r, float h) : base(r)
        {
            Console.Out.WriteLine
                ("Valjak poluprecnika osnove " + r + " i visine " + h);
            this.h = h;
        }
        public float Povrsina
        {
            get { return 2 * 3.14f * r * (r + h); }
        }
        public float Zapremina
        {
            get { return Povrsina * h; } //i ovo u main
        }
    }
}