using static System.Console;
namespace file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "note.txt";
            //string path2 = "note1.txt";
            //File.WriteAllText(path, "aaa");
            //File.AppendAllText(path, "bbb");
            //if (File.Exists(path))
            //{
            //    string content = File.ReadAllText(path);
            //    string[] lines = File.ReadAllLines(path);
            //    Console.WriteLine($"Content: {content}");
            //    for (int i = 0; i < lines.Length; i++)
            //    {
            //        Console.WriteLine($"Line {i + 1}: {lines[i]}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("File not exist");
            //}
            //string folderPath = "Folder/MiniFolder/MakroFolder/NanoFolder";
            //File.Copy(path, path2, overwrite: true);
            //Console.WriteLine($"File: {path} has been copied to {path2}");
            //if (Directory.Exists(folderPath))
            //    if (!File.Exists(folderPath + path2))
            //    {
            //        File.Move(path2, $"{folderPath}/{path2}");
            //        Console.WriteLine($"Move file to {folderPath}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"File already move");
            //    }
            //else
            //{
            //    Directory.CreateDirectory(folderPath);
            //    Console.WriteLine($"Directory has been created");
            //    File.Move(path2, $"{folderPath}/{path2}");
            //    Console.WriteLine($"Move file to {folderPath}");
            //}

            //File.Delete(path);
            //Console.WriteLine($"{path} is delete");

            //Directory.Delete(folderPath, recursive: true);
            //Console.WriteLine($"{folderPath} is delete ");

            //string folder = "Data";
            //string fileName = "config.txt";

            //string fullName = Path.Combine(folder, fileName);

            //string extention = Path.GetExtension(fullName);//.txt
            //string name = Path.GetFileName(fullName);// config.txt


            //using (StreamReader reader = new StreamReader(fullName))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

            //#region Practic

            //Console.Write("FilePath: ");
            //string filePath = Console.ReadLine();

            //if (File.Exists(filePath))
            //{
            //    try
            //    {
            //        string content = File.ReadAllText(filePath);
            //        WriteLine("File text: ");
            //        WriteLine(content);

            //    }
            //    catch (Exception ex)
            //    {
            //        WriteLine($"Error: {ex.Message}");
            //    }

            //}
            //else
            //{
            //    WriteLine("none file");
            //}

            //Write("Write arr element: ");
            //int n = int.Parse(ReadLine());
            //int[] arr = new int[n];
            //WriteLine($"Write {n} element: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Write($"arr[{i}] = ");
            //    arr[i] = int.Parse(ReadLine());
            //}

            //Write("FilePath: ");
            //string filePath = ReadLine();

            //try
            //{
            //    string[] lines = Array.ConvertAll(arr, x => x.ToString());
            //    File.WriteAllLines(filePath, lines);
            //    WriteLine($"Array has been written to {filePath}");
            //}
            //catch (Exception ex)
            //{
            //    WriteLine($"Error: {ex.Message}");
            //}

            //WriteLine("Arr from file: ");
            //string choise = ReadLine();

            //if(choise == "yes")
            //{
            //    try
            //    {
            //        string[] lines = File.ReadAllLines(filePath);
            //        int[] arrFromFile = Array.ConvertAll(lines, int.Parse);
            //        WriteLine("Array from file: ");
            //        foreach (int item in arrFromFile)
            //        {
            //            WriteLine(item);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        WriteLine($"Error: {ex.Message}");
            //    }
            //}
            //else
            //{
            //    WriteLine("You choose no");
            //}

            //Write("FilePath: ");
            //string path = ReadLine();

            //if(File.Exists(path))
            //{
            //    string content = File.ReadAllText(path);

            //    int sentenceCount = 0;
            //    int uppercaseCount = 0;
            //    int lowercaseCount = 0;
            //    int vowelCount = 0;
            //    int consonantCount = 0;
            //    int digitCount = 0;

            //    string vowels = "aeiouAEIOU";

            //    foreach (char c in content)
            //    {
            //        if (c == '.' || c == '!' || c == '?')
            //        {
            //            sentenceCount++;
            //        }
            //        if (char.IsUpper(c))
            //        {
            //            uppercaseCount++;
            //        }
            //        else if (char.IsLower(c))
            //        {
            //            lowercaseCount++;
            //        }
            //        if (vowels.Contains(c))
            //        {
            //            vowelCount++;
            //        }
            //        else if (char.IsLetter(c))
            //        {
            //            consonantCount++;
            //        }
            //        if (char.IsDigit(c))
            //        {
            //            digitCount++;
            //        }
            //    }

            //    WriteLine("Results:");
            //    WriteLine($"Number of sentences: {sentenceCount}");
            //    WriteLine($"Number of uppercase letters: {uppercaseCount}");
            //    WriteLine($"Number of lowercase letters: {lowercaseCount}");
            //    WriteLine($"Number of vowels: {vowelCount}");
            //    WriteLine($"Number of consonants: {consonantCount}");
            //    WriteLine($"Number of digitCount: {digitCount}");

            //}









#endregion
        }
    }
}

