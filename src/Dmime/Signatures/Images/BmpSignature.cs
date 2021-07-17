using System.Collections.Generic;
using Dmime.Abstractions;
using Dmime.Models;

namespace Dmime.Signatures.Images
{
    internal class BmpSignature : ISignature
    {
        public string MimeType { get; }

        public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

        public string FileExtension { get; }

        public BmpSignature()
        {
            MimeType = "image/bmp";
            FileExtension = ".bmp";
            MagicBytes = new[]
            {
                new MagicBytes
                {
                    Bytes = new byte[] {0x42, 0x4D},
                    Offset = 0
                }
            };
        }
    }
}