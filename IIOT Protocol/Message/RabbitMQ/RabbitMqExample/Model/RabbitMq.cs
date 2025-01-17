namespace RabbitMqExample.Model
{
    internal class RabbitMq
    {
        public string Protocol { get; set; } = string.Empty;
        public string HostName { get; set; } = string.Empty;
        public int Port { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
