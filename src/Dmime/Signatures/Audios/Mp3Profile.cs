using System;
using Dmime.Abstractions;

namespace Dmime.Signatures.Audios
{
    internal class Mp3Signature : ISignature
    {
        public byte[] MagicBytes { get; }

        public int Offset { get; }

        public string FileExtension { get; }

        public string MimeType { get; set; }


        public Mp3Signature()
        {
            Offset = 0;
            MagicBytes = new Byte[] {0x49, 0x44, 0x33};
            MimeType = "audio/mpeg";
            FileExtension = ".mp3";
        }
    }
}