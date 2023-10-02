namespace DirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/home/anotações";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

//                Directory.CreateDirectory(@"/home"); //Create folder
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}