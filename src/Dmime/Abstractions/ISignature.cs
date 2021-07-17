using System.Collections.Generic;

namespace Dmime.Abstractions
{
    public interface ISignature
    {
        IReadOnlyCollection<IMagicBytes> MagicBytes { get; }

        string FileExtension { get; }
        
        string MimeType { get; }
    }
}