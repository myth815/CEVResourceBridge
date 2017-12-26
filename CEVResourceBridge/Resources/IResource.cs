using System.Text;
using System;
namespace CEVResourceBridge.Resources
{
    public interface IResource : IDisposable
    {
        void fromOrginBytes(byte[] input);
        void fromCustomBytes(byte[] input);
        string toXML();
        byte[] toOrginBytes();
        byte[] toCustomBytes();
    }
}