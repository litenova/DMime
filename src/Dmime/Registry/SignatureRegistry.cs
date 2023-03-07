using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dmime.Abstractions;

namespace Dmime.Registry;

internal class SignatureRegistry : ISignatureRegistry
{
    private HashSet<ISignature> _signatures = new();

    public void Register(ISignature signature)
    {
        _signatures.Add(signature);
        _signatures = new HashSet<ISignature>(_signatures.OrderBy(s => s.MagicBytes.Sum(m => m.Bytes.Length + m.Offset)));
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<ISignature> GetEnumerator() => _signatures.GetEnumerator();

    public int Count => _signatures.Count;
}