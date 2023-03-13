using System.Collections.Generic;
using Dmime.Abstractions;

namespace Dmime.Internal.Signatures.Others;

public class ZipSignature : ISignature
{
    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    public IReadOnlyCollection<string> FileExtensions { get; }

    public string MimeType { get; }

    public ZipSignature()
    {
        MimeType = "application/zip";
        FileExtensions = new[] {".zip"};
        MagicBytes = new[]
        {
            new MagicBytes
            {
                Bytes = new byte[] {0x50, 0x4B, 0x03, 0x04},
                Offset = 0,
            },
            new MagicBytes
            {
                Bytes = new byte[] {0x50, 0x4B, 0x4C, 0x49, 0x54, 0x45},
                Offset = 30,
            },
            new MagicBytes
            {
                Bytes = new byte[] {0x50, 0x4B, 0x53, 0x70, 0x58},
                Offset = 526,
            },
            new MagicBytes
            {
                Bytes = new byte[] {0x50, 0x4B, 0x05, 0x06},
                Offset = 0,
            },
            new MagicBytes
            {
                Bytes = new byte[] {0x50, 0x4B, 0x07, 0x08},
                Offset = 0,
            },
            new MagicBytes
            {
                Bytes = new byte[] {0x57, 0x69, 0x6E, 0x5A, 0x69, 0x70},
                Offset = 29152,
            },
            new MagicBytes
            {
                Bytes = new byte[] {0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x01, 0x00},
                Offset = 0,
            },
        };
    }
}