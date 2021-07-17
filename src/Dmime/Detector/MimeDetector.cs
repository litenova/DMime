using System.Collections.Generic;
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
                foreach (var magicByte in signature.MagicBytes)
                {
                    fileContent.Position = 0;

                    var numberOfBytesNeededToDetect = magicByte.Bytes.Length + magicByte.Offset;
                    
                    var bytesToDetectType = new byte[numberOfBytesNeededToDetect];

                    await fileContent.ReadAsync(bytesToDetectType, 0, numberOfBytesNeededToDetect);

                    if (CompareBytes(magicByte.Bytes, bytesToDetectType[magicByte.Offset..]))
                    {
                        return new DetectionResult(signature.FileExtension, signature.MimeType);
                    }    
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