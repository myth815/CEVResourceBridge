using System;
namespace CEVResourceBridge.Resources
{
    public interface IResource : IDisposable
    {
        void fromOrginBytes(byte[] input);
        void fromCustomBytes(byte[] input);
        byte[] toOrginBytes();
        byte[] toCustomBytes();
    }
}