using System.IO;
using System.Threading.Tasks;
using Dmime.Abstractions;
using Dmime.Exceptions;

namespace Dmime.Internal;

public class MimeDetector : IMimeDetector
{
    private readonly ISignatureRegistry _signatureRegistry;

    public MimeDetector(ISignatureRegistry signatureRegistry)
    {
        _signatureRegistry = signatureRegistry;
    }

    public async Task<IDetectionResult> DetectAsync(Stream fileContent)
    {
        foreach (var signature in _signatureRegistry)
        {
            foreach (var magicByte in signature.MagicBytes)
            {
                fileContent.Position = 0;

                var numberOfBytesNeededToDetect = magicByte.Bytes.Length + magicByte.Offset;

                var bytesToDetectType = new byte[numberOfBytesNeededToDetect];

                await fileContent.ReadAsync(bytesToDetectType, 0, numberOfBytesNeededToDetect);
                
                if (CompareBytes(magicByte.Bytes, bytesToDetectType[magicByte.Offset..]))
                {
                    return new DetectionResult(signature.FileExtensions, signature.MimeType);
                }
            }
        }

        throw new FileNotDetectedException();
    }

    public IDetectionResult Detect(Stream fileContent)
    {
        foreach (var signature in _signatureRegistry)
        {
            foreach (var magicByte in signature.MagicBytes)
            {
                fileContent.Position = 0;

                var numberOfBytesNeededToDetect = magicByte.Bytes.Length + magicByte.Offset;

                var bytesToDetectType = new byte[numberOfBytesNeededToDetect];

                fileContent.Read(bytesToDetectType, 0, numberOfBytesNeededToDetect);

                if (CompareBytes(magicByte.Bytes, bytesToDetectType[magicByte.Offset..]))
                {
                    return new DetectionResult(signature.FileExtensions, signature.MimeType);
                }
            }
        }

        throw new FileNotDetectedException();
    }

    private static bool CompareBytes(byte[] magicBytes, byte[] bytesToDetectType)
    {
        for (var i = 0; i < magicBytes.Length; i += 1)
        {
            if (magicBytes[i] != bytesToDetectType[i])
            {
                return false;
            }
        }

        return true;
    }
}