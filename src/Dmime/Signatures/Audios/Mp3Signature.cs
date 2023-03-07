using System;
using System.Collections.Generic;
using Dmime.Abstractions;
using Dmime.Models;

namespace Dmime.Signatures.Audios;

internal class Mp3Signature : ISignature
{
    public IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    public IReadOnlyCollection<string> FileExtensions { get; }

    public string MimeType { get; set; }

    public Mp3Signature()
    {
        MagicBytes = new[]
        {
            new MagicBytes
            {
                Bytes = new byte[] {0x49, 0x44, 0x33},
                Offset = 0
            }
        };
        MimeType = "audio/mpeg";
        FileExtensions = new[] {".mp3"};
    }
}