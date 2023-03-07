using System.IO;
using System.Threading.Tasks;

namespace Dmime.Abstractions;

public interface IMimeDetector
{
    Task<IDetectionResult> DetectAsync(Stream fileContent);
}