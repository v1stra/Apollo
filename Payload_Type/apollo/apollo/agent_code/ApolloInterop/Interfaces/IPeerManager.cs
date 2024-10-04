using NopolloInterop.Classes.P2P;
using NopolloInterop.Structs.MythicStructs;
namespace NopolloInterop.Interfaces
{
    public interface IPeerManager
    {
        Peer AddPeer(PeerInformation info);
        bool Remove(string uuid);
        bool Remove(IPeer peer);
        bool Route(DelegateMessage msg);
    }
}
