using System.Collections.Generic;
using Dmime.Abstractions;

namespace Dmime.Internal.Signatures.Images;

public class JpegSignature : ISignature
{
    public string MimeType { get; }

    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    public IReadOnlyCollection<string> FileExtensions { get; }


    public JpegSignature()
    {
        MimeType = "image/jpeg";
        FileExtensions = new[] {".jpeg", ".jpg", ".jpe"};
        MagicBytes = new[]
        {
            new MagicBytes
            {
                Bytes = new byte[] {0xff, 0xd8},
                Offset = 0
            }
        };
    }
}