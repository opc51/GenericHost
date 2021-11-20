// See https://aka.ms/new-console-template for more information
using ConfigurationInjection;
using Microsoft.Extensions.Configuration;


// gives us a list of key value pairs
IConfigurationRoot configRoot = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddCommandLine(args)
    .Build();

PictureDetails thumbnail = configRoot.GetSection("thumbnail")
    .Get<PictureDetails>();
Console.WriteLine($"Thumbnail image size is {thumbnail.width}");
Console.WriteLine($"Thumbnail file prefix is {thumbnail.filePrefix}");


Console.WriteLine($"Processing picture called : {args[0]}");
Console.WriteLine($"The medium is : {args[1]}");
Console.WriteLine($"Default image size is : {configRoot["DefaultPictureSize"]}");

Console.ReadLine();


