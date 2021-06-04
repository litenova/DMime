using Dmime.Abstractions;
using Dmime.Signatures.Audios;
using Dmime.Signatures.Documents;
using Dmime.Signatures.Images;
using Dmime.Signatures.Videos;

namespace Dmime.Registry
{
    public static class SignatureRegistryAccessor
    {
        public static ISignatureRegistry Registry { get; }

        static SignatureRegistryAccessor()
        {
            Registry = new SignatureRegistry();
            
            // Audios
            Registry.Register(new Mp3Signature());
            
            // Documents
            Registry.Register(new PdfSignature());
            
            // Images
            Registry.Register(new BmpSignature());
            Registry.Register(new GifSignature());
            Registry.Register(new JpegSignature());
            Registry.Register(new PngSignature());
            Registry.Register(new WebpSignature());
            
            // Videos
            Registry.Register(new Mp4Signature());
        }
    }
}