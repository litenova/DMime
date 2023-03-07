using System.IO;
using System.Threading.Tasks;
using Dmime.Extensions;
using FluentAssertions;
using Xunit;

namespace Dmime.UnitTests
{
    public class ImageDecoderTests
    {
        [Fact]
        public async Task Bmp_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","bmp-sample-512w-512h.bmp"));

            var result = await stream.DetectMimeTypeAsync();

            result.MimeType.Should().Be("image/bmp");
            result.FileExtension.Should().Be(".bmp");
        }

        [Fact]
        public async Task Jpeg_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","jpg-sample-313w-234h.jpg"));

            var result = await stream.DetectMimeTypeAsync();

            result.MimeType.Should().Be("image/jpeg");
            result.FileExtension.Should().Be(".jpg");
        }

        [Fact]
        public async Task Png_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","png-sample-300w-300h.png"));

            var result = await stream.DetectMimeTypeAsync();

            result.MimeType.Should().Be("image/png");
            result.FileExtension.Should().Be(".png");
        }

        [Fact]
        public async Task Webp_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","webp-sample-550w-404h.webp"));

            var result = await stream.DetectMimeTypeAsync();

            result.MimeType.Should().Be("image/webp");
            result.FileExtension.Should().Be(".webp");
        }
        
        [Fact]
        public async Task Wmf_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","mwf-sample.wmf"));

            var result = await stream.DetectMimeTypeAsync();

            result.MimeType.Should().Be("image/wmf");
            result.FileExtension.Should().Be(".wmf");
        }
        
        [Fact]
        public async Task Tiff_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","tiff-sample.tiff"));

            var result = await stream.DetectMimeTypeAsync();

            result.MimeType.Should().Be("image/tiff");
            result.FileExtension.Should().Be(".tiff");
        }
        
        [Fact]
        public async Task mp4_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","mp4-sample.mp4"));
            
            var result = await stream.DetectMimeTypeAsync();
            
            result.MimeType.Should().Be("video/mp4");
            result.FileExtension.Should().Be(".mp4");
        }
        
        [Fact]
        public async Task pdf_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","pdf-sample.pdf"));
            
            var result = await stream.DetectMimeTypeAsync();
            
            result.MimeType.Should().Be("application/pdf");
            result.FileExtension.Should().Be(".pdf");
        }
        
                
        [Fact]
        public async Task mp3_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","mp3-sample.mp3"));
            
            var result = await stream.DetectMimeTypeAsync();
            
            result.MimeType.Should().Be("audio/mpeg");
            result.FileExtension.Should().Be(".mp3");
        }
        
        [Fact]
        public async Task ico_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","ico-sample.ico"));
            
            var result = await stream.DetectMimeTypeAsync();
            
            result.MimeType.Should().Be("image/x-icon");
            result.FileExtension.Should().Be(".ico");
        }
        
        [Fact]
        public async Task emf_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","emf-sample.emf"));
            
            var result = await stream.DetectMimeTypeAsync();
            
            result.MimeType.Should().Be("image/emf");
            result.FileExtension.Should().Be(".emf");
        }
    }
}