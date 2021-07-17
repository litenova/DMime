using System.Collections.Generic;
using Dmime.Abstractions;
using Dmime.Models;

namespace Dmime.Signatures.Videos
{
    public class Mp4Signature : ISignature
    {
        public string MimeType { get; }

        public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

        public string FileExtension { get; }


        public Mp4Signature()
        {
            MimeType = "video/mp4";
            FileExtension = ".mp4";
            MagicBytes = new[]
            {
                new MagicBytes
                {
                    Bytes = new byte[] {0x66, 0x74, 0x79, 0x70},
                    Offset = 4
                }
            };
        }
    }
}