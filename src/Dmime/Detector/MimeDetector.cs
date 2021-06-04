using System.IO;
using System.Threading.Tasks;
using Dmime.Abstractions;
using Dmime.Exceptions;
using Dmime.Models;

namespace Dmime.Detector
{
    public class MimeDetector : IMimeDetector
    {
        private readonly ISignatureRegistry _registry;

        public MimeDetector(ISignatureRegistry registry)
        {
            _registry = registry;
        }

        public async Task<IDetectionResult> DetectAsync(Stream fileContent)
        {
            foreach (var signature in _registry)
            {
                fileContent.Position = 0;
                
                var bytesToDetectType = new byte[signature.MagicBytes.Length + signature.Offset];

                await fileContent.ReadAsync(bytesToDetectType, 0, signature.MagicBytes.Length + signature.Offset);

                if (CompareBytes(signature.MagicBytes, bytesToDetectType[signature.Offset..]))
                {
                    return new DetectionResult(signature.FileExtension, signature.MimeType);
                }
            }

            throw new FileNotDetectedException();
        }

        private bool CompareBytes(byte[] magicBytes, byte[] bytesToDetectType)
        {
            for (int i = 0; i < magicBytes.Length; i += 1)
            {
                if (magicBytes[i] != bytesToDetectType[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}