﻿using System;

namespace NopolloInterop.Classes
{
    public class UUIDEventArgs : EventArgs
    {
        public readonly string UUID;
        public UUIDEventArgs(string uuid)
        {
            UUID = uuid;
        }
    }
}
