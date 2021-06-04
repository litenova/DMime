using Dmime.Abstractions;

namespace Dmime.Signatures.Images
{
    internal class GifSignature : ISignature
    {
        public string MimeType { get; }

        public byte[] MagicBytes { get; }

        public int Offset { get; }

        public string FileExtension { get; }

        public GifSignature()
        {
            MimeType = "image/gif";
            FileExtension = ".gif";
            Offset = 0;
            MagicBytes = new byte[] {0x47, 0x49, 0x46, 0x38};
        }
    }
}