using System.IO;
using CEVResourceBridge.Utils;

namespace CEVResourceBridge.Resources
{
    public struct FileHeader_0x746
    {
        public string signature;
        public uint version;
        public uint chunkCount;
        public uint chunkTableOffset;

        static string GetExpectedSignature()
        {
            return "CrCh";
        }

        bool HasValidSignature()
        {
            return signature == GetExpectedSignature();
        }

        public void fillDefault(uint __chunkCount, uint __chunkTableOffset)
        {
            signature = GetExpectedSignature();
            version = 123;
            chunkCount = __chunkCount;
            chunkTableOffset = __chunkTableOffset;
        }

        public void read(ByteArray __bytes)
        {
            signature = __bytes.readUTFBytes(4);
            version = __bytes.readUnsignedInt();
            chunkCount = __bytes.readUnsignedInt();
            chunkTableOffset = __bytes.readUnsignedInt();
        }

        public void write(ByteArray __bytes)
        {
            __bytes.writeUTFBytes(signature);
            __bytes.writeUnsignedInt(version);
            __bytes.writeUnsignedInt(chunkCount);
            __bytes.writeUnsignedInt(chunkTableOffset);
        }
    };
    public class FIleStructs
    {

    }
}