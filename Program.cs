using System.IO;

namespace SystemIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path1 = "D:\\Csharp";
            String[] dics1 = Directory.GetDirectories(path1);
            for (int i = 0; i < dics1.Length; i++)
            {
                Console.WriteLine(dics1[i]);
            }

            Console.WriteLine();

            String path2 = "D:\\Csharp";
            String[] dics2 = Directory.GetFiles(path2);
            for (int i = 0; i < dics2.Length; i++)
            {
                Console.WriteLine(dics2[i]);
            }
        }
    }
}