using System.Collections.Generic;
using Dmime.Abstractions;
using Dmime.Models;

namespace Dmime.Signatures.Images
{
    public class JpegSignature : ISignature
    {
        public string MimeType { get; }

        public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

        public string FileExtension { get; }


        public JpegSignature()
        {
            MimeType = "image/jpeg";
            FileExtension = ".jpg";
            MagicBytes = new[]
            {
                new MagicBytes
                {
                    Bytes = new byte[] {0xff, 0xd8},
                    Offset = 0
                }
            };
        }
    }
}