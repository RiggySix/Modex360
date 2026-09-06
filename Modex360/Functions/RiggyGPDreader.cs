using System;
using System.IO;
using System.Text;

namespace Modex360.Functions
{
    internal static class RiggyGPDReader
    {
        public static byte[] ReadEntry(string zipPath, string entryName)
        {
            entryName = entryName.Replace('\\', '/');

            using (FileStream fs = new FileStream(zipPath, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                long fileLength = fs.Length;
                long searchStart = Math.Max(0, fileLength - 65557);
                fs.Seek(searchStart, SeekOrigin.Begin);
                byte[] tail = br.ReadBytes((int)(fileLength - searchStart));

                int eocdOffset = -1;
                for (int i = tail.Length - 22; i >= 0; i--)
                {
                    if (tail[i] == 0x50 && tail[i + 1] == 0x4B && tail[i + 2] == 0x05 && tail[i + 3] == 0x06)
                    {
                        eocdOffset = i;
                        break;
                    }
                }
                if (eocdOffset == -1)
                    return null;

                int entryCount = BitConverter.ToUInt16(tail, eocdOffset + 10);
                uint centralDirOffset = BitConverter.ToUInt32(tail, eocdOffset + 16);

                fs.Seek(centralDirOffset, SeekOrigin.Begin);
                for (int i = 0; i < entryCount; i++)
                {
                    uint sig = br.ReadUInt32();
                    if (sig != 0x02014b50)
                        return null;

                    br.ReadBytes(6);
                    ushort compressionMethod = br.ReadUInt16();
                    br.ReadBytes(8);
                    uint compressedSize = br.ReadUInt32();
                    br.ReadBytes(4);
                    ushort fileNameLength = br.ReadUInt16();
                    ushort extraFieldLength = br.ReadUInt16();
                    ushort fileCommentLength = br.ReadUInt16();
                    br.ReadBytes(8);
                    uint localHeaderOffset = br.ReadUInt32();
                    byte[] nameBytes = br.ReadBytes(fileNameLength);
                    string name = Encoding.ASCII.GetString(nameBytes).Replace('\\', '/');
                    br.ReadBytes(extraFieldLength + fileCommentLength);

                    if (name == entryName)
                    {
                        fs.Seek(localHeaderOffset, SeekOrigin.Begin);
                        uint localSig = br.ReadUInt32();
                        if (localSig != 0x04034b50)
                            return null;

                        br.ReadBytes(22);
                        ushort localNameLength = br.ReadUInt16();
                        ushort localExtraLength = br.ReadUInt16();
                        br.ReadBytes(localNameLength + localExtraLength);

                        byte[] compressedData = br.ReadBytes((int)compressedSize);

                        if (compressionMethod == 0)
                            return compressedData;

                        if (compressionMethod == 8)
                            return Ionic.Zlib.DeflateStream.UncompressBuffer(compressedData);

                        return null;
                    }
                }
                return null;
            }
        }
    }
}