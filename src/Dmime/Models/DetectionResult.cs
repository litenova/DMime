using Dmime.Abstractions;

namespace Dmime.Models
{
    internal class DetectionResult : IDetectionResult
    {
        public DetectionResult(string fileExtension, string mimeType)
        {
            FileExtension = fileExtension;
            MimeType = mimeType;
        }

        public string FileExtension { get; }

        public string MimeType { get; }
    }
}