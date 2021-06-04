using System.Collections.Generic;

namespace Dmime.Abstractions
{
    public interface ISignatureRegistry : IEnumerable<ISignature>
    {
        void Register(ISignature signature);
    }
}