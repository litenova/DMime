using System.Collections.Generic;
using Dmime.Abstractions;

namespace Dmime.Internal.Signatures.Images;

public class PngSignature : ISignature
{
    public string MimeType { get; }

    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    public IReadOnlyCollection<string> FileExtensions { get; }

    public PngSignature()
    {
        MimeType = "image/png";
        FileExtensions = new[] {".png"};
        MagicBytes = new[]
        {
            new MagicBytes
            {
                Bytes = new byte[] {0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A},
                Offset = 0,
            }
        };
    }
}