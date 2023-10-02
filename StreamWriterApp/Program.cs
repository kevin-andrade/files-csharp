namespace StreamWriterAppApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"/home/anotações/file.txt";
            string targetPath = @"/home/anotações/filex.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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