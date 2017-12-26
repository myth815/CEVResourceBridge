using CEVResourceBridge.Resources;
using System.Xml;
using CEVResourceBridge.Utils;
namespace CEVResourceBridge.Resources.CGF
{
    public class CGFResource : IResource
    {
        FileHeader_0x746 _header;
        List<Chunk> _chunks;
        public CGFResource()
        {
            _header = new FileHeader_0x746();
            _chunks = new List<Chunk>();
        }

        public void fromOrginBytes(ByteArray input)
        {
            _header.read(input);
            for (int i = 0; i < _header.chunkCount; i++)
            {
                __chunks __chunk = new Chunk();
                __chunk.read(input);
                _chunks.Add(__chunk);
            }
        }

        public void fromCustomBytes(ByteArray input)
        {

        }

        public XmlDocument toXML()
        {
            return null;
        }

        public ByteArray toOrginBytes()
        {
            return null;
        }

        public ByteArray toCustomBytes()
        {
            return null;
        }

        public void Dispose()
        {

        }
    }
}