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

            var result = await stream.DetectMimeType();

            result.MimeType.Should().Be("image/bmp");
            result.FileExtension.Should().Be(".bmp");
        }

        [Fact]
        public async Task Jpeg_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","jpg-sample-313w-234h.jpg"));

            var result = await stream.DetectMimeType();

            result.MimeType.Should().Be("image/jpeg");
            result.FileExtension.Should().Be(".jpg");
        }

        [Fact]
        public async Task Png_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","png-sample-300w-300h.png"));

            var result = await stream.DetectMimeType();

            result.MimeType.Should().Be("image/png");
            result.FileExtension.Should().Be(".png");
        }

        [Fact]
        public async Task Webp_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","webp-sample-550w-404h.webp"));

            var result = await stream.DetectMimeType();

            result.MimeType.Should().Be("image/webp");
            result.FileExtension.Should().Be(".webp");
        }
        
        [Fact]
        public async Task mp4_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","mp4-sample.mp4"));
            
            var result = await stream.DetectMimeType();
            
            result.MimeType.Should().Be("video/mp4");
            result.FileExtension.Should().Be(".mp4");
        }
        
        [Fact]
        public async Task pdf_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","pdf-sample.pdf"));
            
            var result = await stream.DetectMimeType();
            
            result.MimeType.Should().Be("application/pdf");
            result.FileExtension.Should().Be(".pdf");
        }
        
                
        [Fact]
        public async Task mp3_should_be_detected_correctly()
        {
            FileStream stream = File.OpenRead(Path.Combine("Files","mp3-sample.mp3"));
            
            var result = await stream.DetectMimeType();
            
            result.MimeType.Should().Be("audio/mpeg");
            result.FileExtension.Should().Be(".mp3");
        }
    }
}