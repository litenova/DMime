using System.Collections.Generic;
using Dmime.Abstractions;
using Dmime.Models;

namespace Dmime.Signatures.Images;

public class IcoSignature : ISignature
{
    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    public string FileExtension { get; }

    public string MimeType { get; }

    public IcoSignature()
    {
        MimeType = "image/x-icon";
        FileExtension = ".ico";
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