namespace Dmime.Abstractions
{
    public interface IMagicBytes
    {
        int Offset { get; }
        byte[] Bytes { get; }
    }
}