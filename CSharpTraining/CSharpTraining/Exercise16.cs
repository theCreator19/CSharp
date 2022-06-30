using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CSharpTraining
{
    public class Exercise16
    {
        public void FileOperation()
        {
            //created object for FileOperations
            var fileOperations = new FileOperations();
            Console.Write("Enter Directory Path : ");
            string filepath = Console.ReadLine();
            int count;
            //calling NumberOfTextFiles Method
            count = fileOperations.NumberOfTextFiles(filepath);
            Console.WriteLine("Number of Text Files in the Directory : {0}",count);
            Console.WriteLine();
            Console.WriteLine("============================================================================");
            Console.WriteLine();
            //calling NumberOfFilesPerExtensionType Method
            fileOperations.NumberOfFilesPerExtensionType(filepath);
            Console.WriteLine();
            Console.WriteLine("============================================================================");
            Console.WriteLine();
            //calling anomymousObj type
            fileOperations.anonymousObj(filepath);
            Console.WriteLine();
            Console.WriteLine("============================================================================");
            Console.WriteLine();
            //calling FileWithMaximumLength Method
            fileOperations.FileWithMaximumLength(filepath);
        }
    }
}
