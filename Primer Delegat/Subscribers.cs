namespace Primer_Delegat
{
    internal class Subscribers
    {
        private string userName;
        public string UserName { get => userName; set => userName = value; }

        public Subscribers() { UserName = null; }
        public Subscribers(string userName)
        {
            UserName = userName;
        }

        //Ova metoda se poziva kada se primi obavestenje
        public void ReceiveNotification(string message)
        {
            Console.WriteLine($"{UserName} je primio obaveštenje: {message}");
        }

        //Prijava na kanal 
        public void Subscribe(YoutubeChannel channel)
        {
            channel.notifySubs += ReceiveNotification;
            Console.WriteLine($"{UserName} have subscribed on {channel.Name}.");
            channel.Subscribers++;
        }

        //Odjava sa kanala
        public void Unsubscribe(YoutubeChannel channel)
        {
            channel.notifySubs -= ReceiveNotification;
            Console.WriteLine($"{UserName} have unsubscribed on {channel.Name}.");
            channel.Subscribers--;
        }
      
    }
}
