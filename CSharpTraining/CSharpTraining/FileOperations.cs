using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
namespace CSharpTraining
{
    
    public class FileOperations
    {
        //using Anonumous types
        public delegate void TopFiveLargestFiles(string path );
        //this method will return the number of text files in the whole directory (*.txt).
        public int NumberOfTextFiles(string path)
        {
            return Directory.GetFiles(@path, "*.txt", SearchOption.AllDirectories).Length;
        }
        //this method will return the number of files per extension type from the whole directory.
        public void NumberOfFilesPerExtensionType(string path)
        {
            var directory = new DirectoryInfo(@path);
            
            var extensionCount = directory.EnumerateFiles("*.*", SearchOption.AllDirectories).GroupBy(e => e.Extension).Select(r => new { Extension = r.Key, Count = r.Count() }).ToList();
            foreach (var extension in extensionCount)
            {
                Console.WriteLine("Extension Type : {0}\tNumber Of Extensions :  {1}", extension.Extension,extension.Count);
            }
        }

        // this method will return the top 5 largest files, along with their file size (using anonymous types) of a particular directory.
        public TopFiveLargestFiles anonymousObj = delegate(string path)
        {
            Dictionary<string, long> dict = new Dictionary<string, long>();

            string[] filesInDir = Directory.GetFiles(path);
            foreach (var item in  filesInDir)
            {
                FileInfo fileInfo = new FileInfo(item);
                long size = fileInfo.Length;
                dict.Add(item, size);
            }

            var sortDict = from fileDict in dict orderby fileDict.Value descending select fileDict;
            Console.WriteLine("Top Five Largest Files ");
            foreach(var it in sortDict.Take(5)) Console.WriteLine(it);
        };

        //this method will return the file with maximum length of a particular directory.
        public void FileWithMaximumLength(string path)
        {
            Dictionary<string, long> dict = new Dictionary<string, long>();

            string[] filesInDir = Directory.GetFiles(path);
            foreach (var item in filesInDir)
            {
                FileInfo fileInfo = new FileInfo(item);
                long size = fileInfo.Length;
                dict.Add(item, size);
            }



            var sortDict = from fileDict in dict orderby fileDict.Value descending select fileDict;
            Console.WriteLine("File With Maximum Length ");
            foreach (var it in sortDict.Take(1)) Console.WriteLine(it);
        }
    }
}
