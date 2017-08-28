namespace Lykke.TcpSockets.Client
{
    public interface IClientSocketConsumer<out TService>
        where TService : ITcpService
    {
        TService GetConnection();
    }
}