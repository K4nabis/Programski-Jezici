namespace Primer_Delegat
{
    //Delegat koji prima poruku
    public delegate void NotifySubscribers(string message);
 
    public class YoutubeChannel
    {
        //Delegat koji poziva sve pretplatnike
        public NotifySubscribers notifySubs;

        private string name;
        private int subscribers;
        public string Name { get => name; set => name = value; }
        public int Subscribers { get => subscribers; set => subscribers = value; }
      
        public YoutubeChannel(string name)
        {
            this.name = name;
            this.subscribers = 0;
        }

        public void PublishVideo(string videoTitle)
        {
            Console.WriteLine("\n---DELEGAT---");
            string message = "New video: " + videoTitle;
            notifySubs?.Invoke(message);
            Console.WriteLine("-------------\n");

            /* Invoke se koristi za eksplicitno pozivanje delegata, tj. za izvrsavanje svih metoda
            koje su povezane (prikljucene) na taj delegat.
            
            * notifySubs?: Proverava da li delegat notifySubs nije null, tj. da li su na njega
             priključene bilo koje metode. Operator ?. je null-conditional operator koji osigurava da se Invoke
             pozove samo ako notifySubs nije null.
            
             * Invoke(message): Ako delegat nije null, poziva sve metode koje su 
             priključene na njega, prosleđujući im argument message.*/
        }
        public void SubCount() => Console.WriteLine("Total subs: "+ Subscribers);
    }
}
