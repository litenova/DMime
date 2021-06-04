using Dmime.Abstractions;

namespace Dmime.Signatures.Documents
{
    public class PdfSignature : ISignature
    {
        public string MimeType { get; }

        public byte[] MagicBytes { get; }

        public int Offset { get; }

        public string FileExtension { get; }

        public PdfSignature()
        {
            MimeType = "application/pdf";
            FileExtension = ".pdf";
            Offset = 0;
            MagicBytes = new byte[] {0x25, 0x50, 0x44, 0x46, 0x2d};
        }
    }
}