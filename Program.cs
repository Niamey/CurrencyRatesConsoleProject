// See https://aka.ms/new-console-template for more information
using ConsoleApp2;
using ConsoleApp2.Helpers;
using System.Configuration;
using System.Net;


    FileTools.CheckIfFileExists(ConfigurationManager.AppSettings["Path"]);
    FileTools.CreateNewDirectory(ConfigurationManager.AppSettings["Path"]);
    FileTools.CheckIfFileExistsInDownloadFolder(ConfigurationManager.AppSettings["FileName"]);
    try
    {
        DownloadFileLogic.Main();
    }
    catch (WebException ex)
    {
        Console.WriteLine(ex.Message);
    }
    FileTools.DeleteDirectory(ConfigurationManager.AppSettings["Path"]);
