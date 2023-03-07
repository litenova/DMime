using System.Collections.Generic;

namespace Dmime.Abstractions;

public interface IDetectionResult
{
    IReadOnlyCollection<string> FileExtensions { get; }
        
    string MimeType { get; }
}