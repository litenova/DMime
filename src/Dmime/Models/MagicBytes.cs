using Dmime.Abstractions;

namespace Dmime.Models;

public class MagicBytes : IMagicBytes
{
    public int Offset { get; set; }

    public byte[] Bytes { get; set; }
}