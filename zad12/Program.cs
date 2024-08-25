namespace zad12
{
    /// <summary>
    /// U listu ne mozes da stavis odma kao list[0]=1 jer prvo moras da zauzmes mem
    /// znaci list.Add(nesto);
    /// pa tad kad dodas imas 0. mesto itd
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            List<String> list = new List<String>();
            
            list.Add("Nula");
            list[0] = "Nula";
            list.Add("Jedan");
            list[1] = "Jedan";
            list.Add("Dva");
            list[2] = "Dva";
            Console.WriteLine(list.Capacity);

            foreach (String s in list)
                Console.WriteLine(s);

            Console.WriteLine("-----");
            
            Dictionary<int,String> recnik = new Dictionary<int,String>();
            recnik[0] = "Nula";
            recnik[0] = "Nula";
            recnik[1] = "Jedan";
            recnik[1] = "Jedan";
            recnik[2] = "Dva";
            recnik[2] = "Dva";
            foreach(String s in recnik.Values)
                Console.WriteLine(s);
        }

    }
}