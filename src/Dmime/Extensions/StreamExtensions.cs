using System.IO;
using System.Threading.Tasks;
using Dmime.Abstractions;
using Dmime.Detector;
using Dmime.Registry;

namespace Dmime.Extensions
{
    public static class StreamExtensions
    {
        public static IDetectionResult DetectMimeType(this Stream stream)
        {
            var detector = new MimeDetector(SignatureRegistryAccessor.Registry);

            return detector.Detect(stream);
        } 
    }
}