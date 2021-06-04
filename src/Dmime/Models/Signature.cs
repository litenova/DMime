using Dmime.Abstractions;

namespace Dmime.Models
{
    public class Signature : ISignature
    {
        public Signature(byte[] magicBytes, int offset, string fileExtension, string mimeType)
        {
            MagicBytes = magicBytes;
            Offset = offset;
            FileExtension = fileExtension;
            MimeType = mimeType;
        }

        public byte[] MagicBytes { get; }

        public int Offset { get; }

        public string FileExtension { get; }

        public string MimeType { get; }
    }
}