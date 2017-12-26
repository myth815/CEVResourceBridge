using System.Text;
using System;
using System.Xml;
using CEVResourceBridge.Utils;
namespace CEVResourceBridge.Resources
{
    public interface IResource : IDisposable
    {
        void fromOrginBytes(ByteArray input);
        void fromCustomBytes(ByteArray input);
        XmlDocument toXML();
        ByteArray toOrginBytes();
        ByteArray toCustomBytes();
    }
}