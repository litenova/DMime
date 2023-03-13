namespace Dmime.Abstractions;

public class MagicBytes : IMagicBytes
{
    public required int Offset { get; init; }

    public required byte[] Bytes { get; init; }
}