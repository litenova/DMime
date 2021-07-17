using System.Collections.Generic;
using Dmime.Abstractions;
using Dmime.Models;

namespace Dmime.Signatures.Images
{
    internal class WebpSignature : ISignature
    {
        public string MimeType { get; }

        public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

        public string FileExtension { get; }


        public WebpSignature()
        {
            MimeType = "image/webp";
            FileExtension = ".webp";
            MagicBytes = new[]
            {
                new MagicBytes
                {
                    Bytes = new byte[] {0x52, 0x49, 0x46, 0x46},
                    Offset = 0,
                }
            };
        }
    }
}