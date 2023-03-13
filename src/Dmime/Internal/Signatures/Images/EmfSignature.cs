using System.Collections.Generic;
using Dmime.Abstractions;

namespace Dmime.Internal.Signatures.Images;

public class EmfSignature : ISignature
{
    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    public IReadOnlyCollection<string> FileExtensions { get; }

    public string MimeType { get; }

    public EmfSignature()
    {
        MimeType = "image/emf";
        FileExtensions = new[] {".emf"};
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