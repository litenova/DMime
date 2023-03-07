using System.Collections.Generic;
using Dmime.Abstractions;
using Dmime.Models;

namespace Dmime.Signatures.Images;

internal class GifSignature : ISignature
{
    public string MimeType { get; }

    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    public IReadOnlyCollection<string> FileExtensions { get; }

    public GifSignature()
    {
        MimeType = "image/gif";
        FileExtensions = new[] {".gif"};
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