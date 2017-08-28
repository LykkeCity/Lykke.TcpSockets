using System.Threading.Tasks;

namespace Lykke.TcpSockets
{
    
    public interface ISocketNotifyer
    {
        Task Connect();
        Task Disconnect();
    }
    
}