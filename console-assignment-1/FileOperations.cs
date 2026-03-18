using System;
using System.IO;

namespace ConsoleApp1
{
    internal class FileOperations
    {
        static string filePath = "example.txt";
        static string copyPath = "copy.txt";
        static string renamedPath = "renamedExample.txt";
        static string dirPath = "MyFolder";

        // 1. Write multiple lines
        public static void WriteLines()
        {
            string[] lines =
            {
                "First line",
                "Second line",
                "Third line"
            };

            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Lines written.");
        }

        // 2. Append text
        public static void AppendText()
        {
            File.AppendAllText(filePath, "Appended content\n");
            Console.WriteLine("Text appended.");
        }

        // 3. Check file exists
        public static void CheckExists()
        {
            Console.WriteLine(File.Exists(filePath)
                ? "File exists"
                : "File not found");
        }

        // 4. Read all text
        public static void ReadAll()
        {
            Console.WriteLine(File.ReadAllText(filePath));
        }

        // 5. Read line by line
        public static void ReadLineByLine()
        {
            using StreamReader sr = new StreamReader(filePath);
            string line;
            while ((line = sr.ReadLine()) != null)
                Console.WriteLine(line);
        }

        // 6. Copy file
        public static void CopyFile()
        {
            File.Copy(filePath, copyPath, true);
            Console.WriteLine("File copied.");
        }

        // 7. Rename / Move
        public static void RenameFile()
        {
            if (File.Exists(filePath))
            {
                File.Move(filePath, renamedPath, true);
                Console.WriteLine("File renamed.");
            }
        }

        // 8. Delete file
        public static void DeleteFile()
        {
            if (File.Exists(renamedPath))
            {
                File.Delete(renamedPath);
                Console.WriteLine("File deleted.");
            }
        }

        // 9. Create directory
        public static void CreateDirectory()
        {
            Directory.CreateDirectory(dirPath);
            Console.WriteLine("Directory created.");
        }

        // 10. List files
        public static void ListFiles()
        {
            foreach (var f in Directory.GetFiles("."))
                Console.WriteLine(f);
        }

        // 11. List subdirectories
        public static void ListDirectories()
        {
            foreach (var d in Directory.GetDirectories("."))
                Console.WriteLine(d);
        }

        // 12. FileStream (advanced)
        public static void FileStreamDemo()
        {
            byte[] data = { 1, 2, 3 };

            using FileStream fs = new FileStream("bytes.dat", FileMode.Create);
            fs.Write(data, 0, data.Length);

            Console.WriteLine("Binary data written.");
        }

        // 13. Overwrite + Append
        public static void OverwriteAndAppend()
        {
            File.WriteAllText(filePath, "Overwritten text\n");
            File.AppendAllText(filePath, "Extra text\n");
            Console.WriteLine("Overwrite + append done.");
        }
    }
}
