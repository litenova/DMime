namespace Dmime.Abstractions
{
    public interface ISignature
    {
        byte[] MagicBytes { get; }

        int Offset { get; }

        string FileExtension { get; }
        
        string MimeType { get; }
    }
}