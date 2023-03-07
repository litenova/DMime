using System.Collections.Generic;
using Dmime.Abstractions;
using Dmime.Models;

namespace Dmime.Signatures.Images;

public class TiffSignature: ISignature
{
    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }
    public string FileExtension { get; }
    public string MimeType { get; }
    
    public TiffSignature()
    {
        MimeType = "image/tiff";
        FileExtension = ".tiff";
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