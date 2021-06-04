using System.IO;
using System.Threading.Tasks;

namespace Dmime.Abstractions
{
    public interface IMimeDetector
    {
        IDetectionResult Detect(Stream fileContent);
    }
}