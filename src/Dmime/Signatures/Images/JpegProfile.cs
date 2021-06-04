using Dmime.Abstractions;

namespace Dmime.Signatures.Images
{
    public class JpegSignature : ISignature
    {
        public string MimeType { get; }

        public byte[] MagicBytes { get; }

        public int Offset { get; }

        public string FileExtension { get; }


        public JpegSignature()
        {
            MimeType = "image/jpeg";
            FileExtension = ".jpg";
            Offset = 0;
            MagicBytes = new byte[] {0xff, 0xd8};
        }
    }
}