using NopolloInterop.Structs.MythicStructs;

namespace NopolloInterop.Interfaces
{
    public interface IPeer
    {
        bool Start();
        void Stop();
        string GetUUID();
        string GetMythicUUID();
        bool Connected();
        void ProcessMessage(DelegateMessage message);
        bool Finished();
    }
}
