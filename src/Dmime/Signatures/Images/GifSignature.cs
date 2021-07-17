using System.Collections.Generic;
using Dmime.Abstractions;
using Dmime.Models;

namespace Dmime.Signatures.Images
{
    internal class GifSignature : ISignature
    {
        public string MimeType { get; }

        public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

        public string FileExtension { get; }

        public GifSignature()
        {
            MimeType = "image/gif";
            FileExtension = ".gif";
            MagicBytes = new[]
            {
                new MagicBytes
                {
                    Bytes = new byte[] {0x47, 0x49, 0x46, 0x38},
                    Offset = 0
                }
            };
        }
    }
}