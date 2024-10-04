using NopolloInterop.Structs.ApolloStructs;
using System;

namespace NopolloInterop.Interfaces
{
    public interface IProcess
    {
        bool Inject(byte[] code, string arguments = "");
        void WaitForExit();
        void WaitForExit(int milliseconds);

        bool Start();
        bool StartWithCredentials(ApolloLogonInformation logonInfo);

        bool StartWithCredentials(IntPtr hToken);

    }
}
