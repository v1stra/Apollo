using NopolloInterop.Structs.MythicStructs;
using System.Net.Sockets;

namespace NopolloInterop.Interfaces
{
    public interface IRpfwdManager
    {
        bool Route(SocksDatagram dg);
        bool AddConnection(TcpClient client, int ServerID, int port);
        bool Remove(int id);
    }
}
