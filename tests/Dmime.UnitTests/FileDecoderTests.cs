using System.IO;
using System.Threading.Tasks;
using Dmime.Extensions;
using FluentAssertions;
using Xunit;

namespace Dmime.UnitTests;

public class ImageDecoderTests
{
    [Fact]
    public async Task Bmp_should_be_detected_correctly()
    {
        FileStream stream = File.OpenRead(Path.Combine("Files", "bmp-sample-512w-512h.bmp"));

        var result = await stream.DetectMimeType();

        result.MimeType.Should().Be("image/bmp");
        result.FileExtensions.Should().Contain(".bmp");
    }

    [Fact]
    public async Task Jpeg_should_be_detected_correctly()
    {
        FileStream stream = File.OpenRead(Path.Combine("Files", "jpg-sample-313w-234h.jpg"));

        var result = await stream.DetectMimeType();

        result.MimeType.Should().Be("image/jpeg");
        result.FileExtensions.Should().Contain(".jpg");
    }

    [Fact]
    public async Task Png_should_be_detected_correctly()
    {
        FileStream stream = File.OpenRead(Path.Combine("Files", "png-sample-300w-300h.png"));

        var result = await stream.DetectMimeType();

        result.MimeType.Should().Be("image/png");
        result.FileExtensions.Should().Contain(".png");
    }

    [Fact]
    public async Task Webp_should_be_detected_correctly()
    {
        FileStream stream = File.OpenRead(Path.Combine("Files", "webp-sample-550w-404h.webp"));

        var result = await stream.DetectMimeType();

        result.MimeType.Should().Be("image/webp");
        result.FileExtensions.Should().Contain(".webp");
    }

    [Fact]
    public async Task Wmf_should_be_detected_correctly()
    {
        FileStream stream = File.OpenRead(Path.Combine("Files", "mwf-sample.wmf"));

        var result = await stream.DetectMimeType();

        result.MimeType.Should().Be("image/wmf");
        result.FileExtensions.Should().Contain(".wmf");
    }

    [Fact]
    public async Task mp4_should_be_detected_correctly()
    {
        FileStream stream = File.OpenRead(Path.Combine("Files", "mp4-sample.mp4"));

        var result = await stream.DetectMimeType();

        result.MimeType.Should().Be("video/mp4");
        result.FileExtensions.Should().Contain(".mp4");
    }

    [Fact]
    public async Task pdf_should_be_detected_correctly()
    {
        FileStream stream = File.OpenRead(Path.Combine("Files", "pdf-sample.pdf"));

        var result = await stream.DetectMimeType();

        result.MimeType.Should().Be("application/pdf");
        result.FileExtensions.Should().Contain(".pdf");
    }

    [Fact]
    public async Task mp3_should_be_detected_correctly()
    {
        FileStream stream = File.OpenRead(Path.Combine("Files", "mp3-sample.mp3"));

        var result = await stream.DetectMimeType();

        result.MimeType.Should().Be("audio/mpeg");
        result.FileExtensions.Should().Contain(".mp3");
    }

    [Fact]
    public async Task ico_should_be_detected_correctly()
    {
        FileStream stream = File.OpenRead(Path.Combine("Files", "ico-sample.ico"));

        var result = await stream.DetectMimeType();

        result.MimeType.Should().Be("image/x-icon");
        result.FileExtensions.Should().Contain(".ico");
    }

    [Fact]
    public async Task emf_should_be_detected_correctly()
    {
        FileStream stream = File.OpenRead(Path.Combine("Files", "emf-sample.emf"));

        var result = await stream.DetectMimeType();

        result.MimeType.Should().Be("image/emf");
        result.FileExtensions.Should().Contain(".emf");
    }
}