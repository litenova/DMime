using System.Collections.Generic;

namespace Dmime.Abstractions;

public interface ISignature
{
    IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

    IReadOnlyCollection<string> FileExtensions { get; }
        
    string MimeType { get; }
}