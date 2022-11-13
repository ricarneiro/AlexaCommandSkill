// See https://aka.ms/new-console-template for more information
using MediaToolkit;
using MediaToolkit.Model;
using VideoLibrary;

Console.WriteLine("Hello, World!");

SaveMP3("C:\\vscode\\AlexaTest\\Temp\\", "https://www.youtube.com/watch?v=E3KhFYAQoTA", "acdc");

void SaveMP3(string SaveToFolder, string VideoURL, string MP3Name)
{
    var source = @SaveToFolder;
    var youtube = YouTube.Default;
    var vid = youtube.GetVideo(VideoURL);
    File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

    var inputFile = new MediaFile { Filename = source + vid.FullName };
    var outputFile = new MediaFile { Filename = $"{MP3Name}.mp3" };

    using (var engine = new Engine())
    {
        engine.GetMetadata(inputFile);

        engine.Convert(inputFile, outputFile);
    }
}

