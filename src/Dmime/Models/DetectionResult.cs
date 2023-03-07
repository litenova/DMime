using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dmime.Abstractions;

namespace Dmime.Models;

internal class DetectionResult : IDetectionResult
{
    public DetectionResult(IEnumerable<string> fileExtensions, string mimeType)
    {
        FileExtensions = new List<string>(fileExtensions).AsReadOnly();
        MimeType = mimeType;
    }

    public IReadOnlyCollection<string> FileExtensions { get; }

    public string MimeType { get; }
}