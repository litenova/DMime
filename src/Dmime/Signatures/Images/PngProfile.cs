using Dmime.Abstractions;

namespace Dmime.Signatures.Images
{
    public class PngSignature : ISignature
    {
        public string MimeType { get; }

        public byte[] MagicBytes { get; }

        public int Offset { get; }

        public string FileExtension { get; }

        public PngSignature()
        {
            MimeType = "image/png";
            FileExtension = ".png";
            Offset = 0;
            MagicBytes = new byte[] {0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A};
        }
    }
}