using System.Collections.Generic;

namespace Dmime.Abstractions
{
    public interface ISignatureRegistry : IReadOnlyCollection<ISignature>
    {
        void Register(ISignature signature);
    }
}