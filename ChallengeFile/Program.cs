using Challenge.Entities;
using System.Globalization;

namespace ChallengeFile
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                string sourceFolderPath = Path.GetDirectoryName(filePath);
                string targetFolderPath = sourceFolderPath + @"/out";
                string targetFilePath = targetFolderPath + @"summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + ", " + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}