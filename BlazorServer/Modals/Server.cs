namespace BlazorServer.Modals
{
    public class Server
    {
        public Server() {
            int randomNumber = new Random().Next(0, 2);
            ServerIsOnline = randomNumber == 1 ? true : false;
        }
        public int ServerId { get; set; }
        public string? ServerName { get; set; }
        public string? ServerCountry { get; set; }
        public bool ServerIsOnline { get; set; }
    }
}
