using System.Collections.Generic;
using Dmime.Abstractions;

namespace Dmime.Internal.Signatures.Videos;

public class Mp4Signature : ISignature
{
    public string MimeType { get; }

    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    public IReadOnlyCollection<string> FileExtensions { get; }


    public Mp4Signature()
    {
        MimeType = "video/mp4";
        FileExtensions = new[] {".mp4"};
        MagicBytes = new[]
        {
            new MagicBytes
            {
                Bytes = new byte[] {0x66, 0x74, 0x79, 0x70},
                Offset = 4
            }
        };
    }
}