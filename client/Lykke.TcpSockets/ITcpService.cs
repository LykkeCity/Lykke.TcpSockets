using System;
using System.Threading.Tasks;

namespace Lykke.TcpSockets
{
    
    /// <summary>
    /// This interface gets all the envents deserialized from tcp socket stream
    /// </summary>
    public interface ITcpService
    {
        
        Task HandleDataFromSocket(object data);

        Func<object, Task<bool>> SendDataToSocket { get; set; }

        string ContextName { get; }

    }
    
}