namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"C:\Nova pasta/file1.txt";
            string targetPath = @"C:\Nova pasta/file2.txt";

            try
            {
                FileInfo fileInfo = new(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                Console.WriteLine("Success!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}