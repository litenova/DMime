using System.Collections.Generic;

namespace Dmime.Abstractions;

public class DetectionResult : IDetectionResult
{
    public DetectionResult(IEnumerable<string> fileExtensions, string mimeType)
    {
        FileExtensions = new List<string>(fileExtensions).AsReadOnly();
        MimeType = mimeType;
    }

    public IReadOnlyCollection<string> FileExtensions { get; }

    public string MimeType { get; }
}