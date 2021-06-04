using Dmime.Abstractions;

namespace Dmime.Signatures.Images
{
    internal class WebpSignature : ISignature
    {
        public string MimeType { get; }

        public byte[] MagicBytes { get; }

        public int Offset { get; }

        public string FileExtension { get; }


        public WebpSignature()
        {
            MimeType = "image/webp";
            FileExtension = ".webp";
            Offset = 0;
            MagicBytes = new byte[] {0x52, 0x49, 0x46, 0x46};
        }
    }
}