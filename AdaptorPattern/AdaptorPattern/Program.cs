// See https://aka.ms/new-console-template for more information
using AdaptorPattern;


List<string> list = new List<string> { "apple", "banana", "cherry" };
IFileMaker csvWriter = new CsvFileMaker(list);
Console.WriteLine(csvWriter.GetFileText());
Console.WriteLine("------------------------");
IFileMaker jsonWriter = new JsonDataAdapter<List<string>>(csvWriter);
Console.WriteLine(jsonWriter.GetFileText());

FileGateway fileGateway = new FileGateway(jsonWriter.GetFileText(), "output.json");
fileGateway.SaveFile();






