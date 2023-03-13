using System.Collections.Generic;
using Dmime.Abstractions;

namespace Dmime.Internal.Signatures.Images;

public class TiffSignature : ISignature
{
    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    public IReadOnlyCollection<string> FileExtensions { get; }

    public string MimeType { get; }

    public TiffSignature()
    {
        MimeType = "image/tiff";
        FileExtensions = new[] {".tiff", ".tif"};
        MagicBytes = new[]
        {
            new MagicBytes
            {
                Bytes = new byte[] {0x49, 0x20, 0x49},
                Offset = 0
            },
            new MagicBytes
            {
                Bytes = new byte[] {0x49, 0x49, 0x2A, 0x00},
                Offset = 0
            }
        };
    }
}