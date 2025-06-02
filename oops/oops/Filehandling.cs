using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace oops
{
    class Filehandling
    {
        public void FileCreationUsingFileSteam()
        {
            // Set the file path where you want to  create the file in your Disk
            string filePath = @"K:\Deepu Practice\oops\oops\FilleExample\MyFile.txt";
            //create an Instance of FileStream Class by specifying the file path and file Mode
            // FileMode is going to be Create as we are going to create a new file
            FileStream fileStream = new FileStream(filePath, FileMode.Create);
            //Finally close the fileStream Objec
            fileStream.Close();
            Console.WriteLine("File has been created and the path is K://Deepu Practice/oops/oops/FilleExample");
        }
        public void FileOpenAndWrite()
        {
            string filePath = @"K:\Deepu Practice\oops\oops\FilleExample\MyFile.txt";
            //Create an Instance of FileStream class by specifying the File path and file mode
            // FileMode is going to be append as we ae going to append some text in the file
            FileStream fileStream = new FileStream(filePath, FileMode.Append);
            //cereate the file byte array which contains the string data to be appended in the file
            byte[] bytedata = Encoding.Default.GetBytes("C# is an object Oriented Programming Language");
            //Write the Byte Array into the file Stream Object using the write Method
            //array (bytedata):The zero-based byte offset in the array from which to begin copying bytes to the stream.
            // count (bytedata.Length): the maximum number of bytes to write.
            fileStream.Write(bytedata, 0, bytedata.Length);
            //finally close the fileStream
            fileStream.Close();
            Console.WriteLine("Successfully--");
        }
        public void FileRead()
        {
            string filePath = @"K:\Deepu Practice\oops\oops\FilleExample\MyFile.txt";
            string data;
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (StreamReader str = new StreamReader(fileStream))
            {
                data = str.ReadToEnd();
            }
            Console.WriteLine(data);
        }
    }
}
