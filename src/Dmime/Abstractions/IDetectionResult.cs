namespace Dmime.Abstractions
{
    public interface IDetectionResult
    {
        string FileExtension { get; }
        
        string MimeType { get; }
    }
}