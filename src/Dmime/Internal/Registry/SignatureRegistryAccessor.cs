using Dmime.Abstractions;
using Dmime.Internal.Signatures.Audios;
using Dmime.Internal.Signatures.Documents;
using Dmime.Internal.Signatures.Images;
using Dmime.Internal.Signatures.Others;
using Dmime.Internal.Signatures.Videos;

namespace Dmime.Internal.Registry;

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
        Registry.Register(new IcoSignature());
        Registry.Register(new WmfSignature());
        Registry.Register(new TiffSignature());
        Registry.Register(new EmfSignature());
            
        // Videos
        Registry.Register(new Mp4Signature());
            
        // Others
        Registry.Register(new ZipSignature());
    }
}