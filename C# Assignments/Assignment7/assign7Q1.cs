using System.IO;

namespace FileIO
{
    public class program
    {
        public static void Main()
        {
            try
            {
                string path = @"C:\Users\LAKSHMISREE\Source\Repos\FileIO\FileIO"; string[] files = Directory.GetFiles(path); string[] directories = Directory.GetDirectories(path); Console.WriteLine($"Files in{path}\n"); foreach (string file in files)
                {
                    string filesName = Path.GetFileName(file); Console.WriteLine(filesName); string filepath = Path.Combine(path, filesName); FileInfo myfile = new FileInfo(filepath);                    //OPEINING fike to read                    StreamReader sr =myfile.OpenText();                    string data = "";                    while((data = sr.ReadLine()) != null)                    {                        Console.WriteLine(data);    
                }
                Console.WriteLine("\n");
            }
Console.WriteLine($"subdirectories inside{path}\n");
            foreach (string directory in directories)
            {
                DirectoryInfo directoryinfo = new DirectoryInfo(directory);
                directoryinfo.GetDirectories();
                string directoryName = directoryinfo.FullName;
                Console.WriteLine(directoryName);
            }
        }
catch (IOException e)
{
Console.WriteLine(e);
}
}
}
} 

