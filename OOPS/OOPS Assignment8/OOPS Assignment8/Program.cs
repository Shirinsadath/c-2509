using Microsoft.VisualBasic;
using OOPS_Assignment8;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Text.Json;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace FileDirectory
{
    class Program
    {

        //1. File and Directory Operations in C# 
        //        Question: 
        //Write a C# program that performs the following tasks: 
        // Creates a directory named "MyTestDirectory" if it doesn’t exist.
        // Creates a file named "testfile.txt" inside "MyTestDirectory". 
        // Writes "Hello, C#!" to "testfile.txt". 
        // Reads the contents of "testfile.txt" and displays it on the console. 
        // Deletes "testfile.txt" and "MyTestDirectory" after displaying the contents. 
        //static void Main(string[] args)
        //{
        //    string directoryPath = "MyTestDirectory";
        //    string filePath = Path.Combine(directoryPath, "TestFile.txt");

        //    if (!Directory.Exists(directoryPath))
        //    {
        //        Directory.CreateDirectory(directoryPath);
        //    }

        //    File.WriteAllText(filePath, "Hello C#");
        //    Console.WriteLine($"File {filePath} created and written to.");

        //    string fileContent = File.ReadAllText(filePath);
        //    Console.WriteLine($"fileContent {fileContent}");

        //    File.Delete(filePath);
        //    Console.WriteLine($"File {filePath} deleted.");
        //    Directory.Delete(directoryPath);

        //    Console.WriteLine($"directory {directoryPath} successfully deleted");
        //    Console.ReadLine();
        //}

        //========================================================================================================================

        //        2. Stream-based I/O
        //Question: 
        //Write a program in C# that reads a text file "sample.txt" line by line using StreamReader and 
        //writes each line to a new file named "copy.txt" using StreamWriter.

        //static void Main()
        //{

        //    string sourceFilePath = "source.txt";
        //    string destinationFilePath = "destination.txt";



        //    using (StreamReader reader = new StreamReader(sourceFilePath))
        //    using (StreamWriter writer = new StreamWriter(destinationFilePath))
        //    {
        //        string line;
        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            writer.WriteLine(line);
        //        }
        //    }

        //    Console.WriteLine("File copied successfully.");




        //}

        //==============================================================================================

        //static void Main()
        //{
        //    Person person = new Person { Name = "Muhammed Nafi", Age = 30 };
        //    string filePath = "person.json";


        //    string jsonString = JsonSerializer.Serialize(person);
        //    File.WriteAllText(filePath, jsonString);
        //    Console.WriteLine("Object serialized to JSON");


        //    string readJson = File.ReadAllText(filePath);
        //    Person deserializedPerson = JsonSerializer.Deserialize<Person>(readJson);
        //    Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        //}


        //===================================================================================================================
        //        4. Exception Handling in File Operations
        //Question: 
        //Modify the file copy program in Question 2 to handle possible exceptions like
        //FileNotFoundException, UnauthorizedAccessException, and IOException.Display custom error
        //messages for each exception type.


        //static void Main()
        //{

        //    string sourceFilePath = "source.txt";
        //    string destinationFilePath = "destination.txt";

        //    try
        //    {

        //        using (StreamReader reader = new StreamReader(sourceFilePath))
        //        using (StreamWriter writer = new StreamWriter(destinationFilePath))
        //        {
        //            string line;
        //            while ((line = reader.ReadLine()) != null)
        //            {
        //                writer.WriteLine(line);
        //            }
        //        }

        //        Console.WriteLine("File copied successfully.");
        //    }
        //    catch (FileNotFoundException ex)
        //    {
        //        Console.WriteLine($"Source file not found {ex.Message}");
        //    }
        //    catch (UnauthorizedAccessException ex)
        //    {
        //        Console.WriteLine($"Access denied {ex.Message}");

        //    }
        //    catch (IOException ex)
        //    {
        //        Console.WriteLine($"IO exception occurred {ex.Message}");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($" unexpected error occurred {ex.Message}");

        //    }
        //}
        //========================================================================================================================
        //        5. File Search and Modification in Directory
        //Question: 
        //Write a C# program that searches for all .txt files within a directory named "Logs". For each .txt 
        //file found: 
        // Append the current timestamp at the end of the file.
        // Display the filename and its content after modification. 
        //If the "Logs" directory doesn’t exist, create it, add a sample file, and notify the user.

        //static void Main(string[] args)
        //{
        //    string dirPath = "Logs";


        //    string sampleFilePath = Path.Combine(dirPath, "sample.txt");
        //    if (!File.Exists(sampleFilePath))
        //    {
        //        Directory.CreateDirectory(dirPath);
        //        File.WriteAllText(sampleFilePath, "Sample log entry.");
        //        Console.WriteLine("Sample file created in Logs directory.");
        //    }

        //    string[] txtFiles = Directory.GetFiles(dirPath, "*.txt");

        //    foreach (string filePath in txtFiles)
        //    {
        //        // Append timestamp 
        //        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //        File.AppendAllText(filePath, $"\n{timestamp}");

        //        // Display file content after modification 
        //        string content = File.ReadAllText(filePath);
        //        Console.WriteLine($"File: {filePath}\nContent:\n{content}");
        //        Console.WriteLine("Content after modification:");
        //        Console.WriteLine(content);
        //    }

        //}

        //===================================================================================================================

        //        6. Binary File Operations with Streams
        //Question: 
        //Create a C# program that: 
        // Writes an array of integers {10, 20, 30, 40, 50}
        //    to a binary file named "data.bin". 
        // Reads the integers from "data.bin" and displays them on the console.
        //Use BinaryWriter and BinaryReader classes for this operation.

        //static void Main()
        //{
        //    string filePath = "data.bin";
        //    int[] numbers = { 10, 20, 30, 40, 50 };

        //    // Write integers to binary file 
        //    using (BinaryWriter writer = new BinaryWriter(File.Open(filePath,FileMode.Create)))
        //    {
        //        foreach (int number in numbers)
        //        {
        //            writer.Write(number);
        //        }
        //    }

        //    Console.WriteLine("Data written to binary file.");

        //    // Read integers from binary file 
        //    using (BinaryReader reader = new BinaryReader(File.Open(filePath,FileMode.Open)))
        //    {
        //        Console.WriteLine("Reading data from binary file:");
        //        while (reader.BaseStream.Position != reader.BaseStream.Length)
        //        {
        //            int number = reader.ReadInt32();
        //            Console.WriteLine(number);
        //        }
        //    }
        //}

        //===========================================================================================================
        //        7. Custom Exception Handling in File Operations
        //Question: 
        //Create a custom exception class named FileTooLargeException which is thrown when a file
        //exceeds 1 MB in size.Write a program that reads a file's size and throws this exception if the file 
        //size is too large.Otherwise, it should display "File size is acceptable." 

        //static void Main()
        //{
        //    string filePath = "largefile.txt";

        //    try
        //    {
        //        FileInfo fileInfo = new FileInfo(filePath);
        //        if (fileInfo.Length > 1024 * 1024) 
        //        {
        //            throw new FileTooLargeException("The file size exceeds the 1 MB limit."); 
        //        }
        //        Console.WriteLine("File size is acceptable.");
        //    }
        //    catch (FileTooLargeException ex)
        //    {
        //        Console.WriteLine("Custom Exception: " + ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("An error occurred: " + ex.Message);
        //    }
        //}
        //public class FileTooLargeException : Exception
        //{
        //    public FileTooLargeException(string message) : base(message) { }
        //}

        //=============================================================================================================================
        //        8. Text File Serialization and Deserialization with XML
        //Question: 
        //Define a Book class with properties Title, Author, and ISBN.Write a program that serializes an
        //instance of Book to an XML file named "book.xml" and then deserializes it back, displaying the
        //details on the console.

        //    static void Main()
        //    {
        //        Book book = new Book
        //        {
        //            Title = "C# Programming",
        //            Author = "John Doe",
        //            ISBN = "1234567890"
        //        };
        //        string filePath = "book.xml";

        //        // Serialize to XML 
        //        XmlSerializer serializer = new XmlSerializer(typeof(Book));
        //        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        //        {
        //            serializer.Serialize(fs, book);
        //        }
        //        Console.WriteLine("Book object serialized to XML.");

        //        // Deserialize from XML 
        //        Book deserializedBook;
        //        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        //        {
        //            deserializedBook = (Book)serializer.Deserialize(fs);
        //        }
        //        Console.WriteLine($"Title: {deserializedBook.Title}, Author: { deserializedBook.Author}, ISBN: { deserializedBook.ISBN}"); 
        //    }
        //}
        //public class Book
        //{
        //    public string Title { get; set; }
        //    public string Author { get; set; }
        //    public string ISBN { get; set; }
        //}

        //=================================================================================================================================

        
        


}

