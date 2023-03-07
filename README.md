# Dmime
[![CI/CD](https://github.com/litenova/DMime/actions/workflows/publish-packages.yml/badge.svg)](https://github.com/litenova/DMime/actions/workflows/publish-packages.yml)
[![NuGet](https://img.shields.io/nuget/vpre/Dmime.svg)](https://www.nuget.org/packages/Dmime)


A fast and efficient library to detect a given file's MIME type based on the file content regardless of file extension.

* Written in .NET 5
* No Dependencies
* No Reflection
* Easy to Use
* Supports Popular File Types
    * MP4
    * BMP
    * GIF
    * JPEG
    * PNG
    * WEBP
    * PDF
    * MP3
    * EMF
    * TIFF
    * ICO
    * WMF

## Installation

Depending on your usage, follow one of the guidelines below.

### Microsoft Dependency Injection (ASP.NET Core)

Install with NuGet:

```
Install-Package Dmime
Install-Package Dmime.Extensions.MicrosoftDependencyInjection
```

or with .NET CLI:

```
dotnet add package Dmime
dotnet add package Dmime.Extensions.MicrosoftDependencyInjection
```

and configure your desired as below in the `ConfigureServices` method of `Startup.cs`:

```c#
    services.AddMimeDetector();
```

## How to Use

### Extension Method 
Dmime provides a Extension method to `Stream` and `byte[]` types.

```c#
    // an unkown file without extension
    FileStream stream = File.OpenRead("webp-sample-550w-404h");

    var result = await stream.DetectMimeType(); // result = image/webp
```

### Dependency

You can inject `IMimeDetector` to your desired services to use DMime

```c#
    [ApiController]
    [Route("[controller]")]
    public class UploadController
    {
        private readonly IMimeDetector _mimeDetector;

        public UploadController(IMimeDetector mimeDetector)
        {
            _mimeDetector = mimeDetector;
        }

        [HttpPost]
        public async Task<IActionResult> SendNotification(IFormFile formFile)
        {
            var streamContent = formFile.OpenReadStream();
                    
            var result = await _mimeDetector.DetectAsync(streamContent);

            return Ok(result);
        }
    }
```

## Sponsor 

Thanks to JetBrains for supporting open source projects by providing JetBrains Rider IDE for free.

[![alt text][image]][hyperlink]

[hyperlink]: https://www.jetbrains.com/
[image]: assets/jetbrains-variant-4.png

