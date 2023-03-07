using System.Collections.Generic;
using Dmime.Abstractions;
using Dmime.Models;

namespace Dmime.Signatures.Images;

public class WmfSignature : ISignature
{
    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }
    public string FileExtension { get; }
    public string MimeType { get; }
    
    public WmfSignature()
    {
        MimeType = "image/wmf";
        FileExtension = ".wmf";
        MagicBytes = new[]
        {
            new MagicBytes
            {
                Bytes = new byte[] {0x01, 0x00, 0x09, 0x00, 0x00, 0x03},
                Offset = 0
            }
        };
    }
}