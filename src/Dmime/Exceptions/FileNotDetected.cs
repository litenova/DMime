using System;

namespace Dmime.Exceptions
{
    [Serializable]
    public class FileNotDetectedException : Exception
    {
        public FileNotDetectedException() : base("The type of file could not be detected")
        {
        }
    }
}