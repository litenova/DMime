using System.Collections.Generic;
using Dmime.Abstractions;
using Dmime.Models;

namespace Dmime.Signatures.Images;

public class EmfSignature : ISignature
{
    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    public string FileExtension { get; }

    public string MimeType { get; }

    public EmfSignature()
    {
        MimeType = "image/emf";
        FileExtension = ".emf";
        MagicBytes = new[]
        {
            new MagicBytes
            {
                Bytes = new byte[] {0x01, 0x00, 0x00, 0x00},
                Offset = 0
            },
        };
    }
}