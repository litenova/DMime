using System.Collections.Generic;
using Dmime.Abstractions;

namespace Dmime.Internal.Signatures.Images;

public class WmfSignature : ISignature
{
    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    public IReadOnlyCollection<string> FileExtensions { get; }

    public string MimeType { get; }

    public WmfSignature()
    {
        MimeType = "image/wmf";
        FileExtensions = new[] {".wmf"};
        MagicBytes = new[]
        {
            new MagicBytes
            {
                Bytes = new byte[] {0x01, 0x00, 0x09, 0x00, 0x00, 0x03},
                Offset = 0
            },
            new MagicBytes
            {
                Bytes = new byte[] {0xD7, 0xCD, 0xC6, 0x9A},
                Offset = 0
            }
        };
    }
}