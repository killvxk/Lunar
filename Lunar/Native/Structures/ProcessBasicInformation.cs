using System;
using System.Runtime.InteropServices;

namespace Pluto.Native.Structures
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    internal readonly struct ProcessBasicInformation
    {
        [FieldOffset(0x08)]
        internal readonly IntPtr PebBaseAddress;
    }
}