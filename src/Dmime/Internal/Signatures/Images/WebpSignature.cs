using System.Collections.Generic;
using Dmime.Abstractions;

namespace Dmime.Internal.Signatures.Images;

internal class WebpSignature : ISignature
{
    public string MimeType { get; }

    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    public IReadOnlyCollection<string> FileExtensions { get; }


    public WebpSignature()
    {
        MimeType = "image/webp";
        FileExtensions = new[] {".webp"};
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