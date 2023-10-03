using System;
using System.IO;

class file
{
    static void Main()
    {
        string filePath = "D:\\training programs\\CodeBaseTest_4\\samples.txt";
        string textToAppend = "This text will be appended to the file.";

       
        if (!File.Exists(filePath))
        {
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.WriteLine(textToAppend);
            }
            Console.WriteLine("File created and text has been added.");
        }
        else
        {
            
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(textToAppend);
            }
            Console.WriteLine("Text has been appended to the file.");
        }
        Console.ReadLine();
    }
}