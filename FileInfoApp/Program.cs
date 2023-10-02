namespace FileInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"/home/anotações/file.txt";

            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}