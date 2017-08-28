using System;
using System.IO;
using System.Threading.Tasks;

namespace Lykke.TcpSockets
{
    public interface ITcpSerializer
    {
        Task<Tuple<object, int>> Deserialize(Stream stream);
        byte[] Serialize(object data);
    }
}