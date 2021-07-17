using System.Collections.Generic;
using Dmime.Abstractions;
using Dmime.Models;

namespace Dmime.Signatures.Documents
{
    public class PdfSignature : ISignature
    {
        public string MimeType { get; }

        public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

        public string FileExtension { get; }

        public PdfSignature()
        {
            MimeType = "application/pdf";
            FileExtension = ".pdf";
            MagicBytes = new[]
            {
                new MagicBytes
                {
                    Bytes = new byte[] {0x25, 0x50, 0x44, 0x46, 0x2d},
                    Offset = 0
                }
            };
        }
    }
}