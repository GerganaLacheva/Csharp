using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03.Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int lastIndexOfBackslash = input.LastIndexOf('\\'); // "\" е запазан символ, за да го приеме пишем "\\"
            string fileNameWithExtension = input.Substring(lastIndexOfBackslash + 1, input.Length - 1 - lastIndexOfBackslash);
                                                            // +1 за да махнем точката                //за да махнем първата част и да вземем само остатъка

            int extensionIndex = fileNameWithExtension.LastIndexOf('.');
            string extension = fileNameWithExtension.Substring(extensionIndex + 1, fileNameWithExtension.Length - 1 - extensionIndex);

            string fileName = fileNameWithExtension.Substring(0, extensionIndex);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
//Extract File
//Create a program that reads the path to a file and subtracts the file name and its extension.
//Examples
//Input	                                                        Output
//C:\Internal\training -internal\Template.pptx                    File name: Template
//                                                                File extension: pptx
// C:\Projects\Data - Structures\LinkedList.cs                    File name: LinkedList
//                                                                File extension: cs

