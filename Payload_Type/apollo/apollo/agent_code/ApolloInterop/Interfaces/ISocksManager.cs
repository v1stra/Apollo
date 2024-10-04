using NopolloInterop.Structs.MythicStructs;

namespace NopolloInterop.Interfaces
{
    public interface ISocksManager
    {
        bool Route(SocksDatagram dg);

        bool Remove(int id);
    }
}
