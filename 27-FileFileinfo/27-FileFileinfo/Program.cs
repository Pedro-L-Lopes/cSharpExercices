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
                String[] lines = File.ReadAllLines(sourcePath);

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
                Console.WriteLine("Error: " + e.Message);
            }

            /*string path = @"C:\Nova pasta/file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            } 
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            } */

            /*string path = @"C:\Nova pasta/file1.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                sr?.Close();
            }*/


            /*string sourcePath = @"C:\Nova pasta/file1.txt";
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
            }*/
        }
    }
}