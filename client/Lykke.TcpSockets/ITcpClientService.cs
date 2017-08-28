namespace Lykke.TcpSockets
{
    public interface ITcpClientService : ITcpService
    {
        object GetPingData();
    }
}