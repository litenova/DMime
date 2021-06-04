using System.Collections;
using System.Collections.Generic;
using Dmime.Abstractions;

namespace Dmime.Registry
{
    internal class SignatureRegistry : ISignatureRegistry
    {
        private readonly HashSet<ISignature> _signatures = new();

        public void Register(ISignature signature) => _signatures.Add(signature);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public IEnumerator<ISignature> GetEnumerator() => _signatures.GetEnumerator();
    }
}