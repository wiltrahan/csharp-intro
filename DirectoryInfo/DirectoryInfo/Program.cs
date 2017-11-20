using System;
using System.Collections.Generic;
using System.IO;
namespace DirectoryInfo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*.*",
                SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
            Directory.Exists("...");

            var directoryInfo = new System.IO.DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}