using Dmime.Abstractions;

namespace Dmime.Signatures.Images
{
    internal class BmpSignature : ISignature
    {
        public string MimeType { get; }

        public byte[] MagicBytes { get; }

        public int Offset { get; }

        public string FileExtension { get; }

        public BmpSignature()
        {
            MimeType = "image/bmp";
            FileExtension = ".bmp";
            Offset = 0;
            MagicBytes = new byte[] {0x42, 0x4D};
        }
    }
}