namespace Primer_Delegat
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            YoutubeChannel channel = new YoutubeChannel("Markovic");
        
            Subscribers sub1 = new Subscribers("Mare");
            Subscribers sub2 = new Subscribers("Ana");

            sub1.Subscribe(channel);
            sub2.Subscribe(channel);

            channel.PublishVideo("Nove trke!!!");

            sub2.Unsubscribe(channel);

            channel.PublishVideo("VLOG!!!");

            channel.SubCount();
        }
    }
}
