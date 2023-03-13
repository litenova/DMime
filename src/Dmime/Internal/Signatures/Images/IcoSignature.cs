using System.Collections.Generic;
using Dmime.Abstractions;

namespace Dmime.Internal.Signatures.Images;

public class IcoSignature : ISignature
{
    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    public IReadOnlyCollection<string> FileExtensions { get; }

    public string MimeType { get; }

    public IcoSignature()
    {
        MimeType = "image/x-icon";
        FileExtensions = new[] {".ico", ".spl"};
        MagicBytes = new[]
        {
            new MagicBytes
            {
                Bytes = new byte[] {0x00, 0x00, 0x01, 0x00},
                Offset = 0
            },
            new MagicBytes
            {
                Bytes = new byte[] {0x00, 0x00, 0x02, 0x00},
                Offset = 0
            }
        };
    }
}