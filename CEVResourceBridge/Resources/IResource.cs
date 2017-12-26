using System.Text;
using System;
using System.Xml;
namespace CEVResourceBridge.Resources
{
    public interface IResource : IDisposable
    {
        void fromOrginBytes(byte[] input);
        void fromCustomBytes(byte[] input);
        XmlDocument toXML();
        byte[] toOrginBytes();
        byte[] toCustomBytes();
    }
}