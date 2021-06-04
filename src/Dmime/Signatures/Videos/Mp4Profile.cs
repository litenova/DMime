using Dmime.Abstractions;

namespace Dmime.Signatures.Videos
{
    public class Mp4Signature : ISignature
    {
        public string MimeType { get; }

        public byte[] MagicBytes { get; }

        public int Offset { get; }

        public string FileExtension { get; }


        public Mp4Signature()
        {
            MimeType = "video/mp4";
            FileExtension = ".mp4";
            Offset = 4;
            MagicBytes = new byte[] {0x66, 0x74, 0x79, 0x70};
        }
    }
}