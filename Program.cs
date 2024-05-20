using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace SystemIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path1 = "D:\\Csharp\\abc";
            String[] dics1 = Directory.GetDirectories(path1); //获取子目录文件夹列表
            for (int i = 0; i < dics1.Length; i++)
            {
                Console.WriteLine(dics1[i]);
            }

            Console.WriteLine("----------------------------");
            List<string> fileList = new List<string>();
            GetChildDirectoiresAndFiles(path1, fileList);

            Console.WriteLine("----------------------------");

            DirectoryInfo direc = new DirectoryInfo(path1);
            direc.Delete(true);
            for (int i = 0; i < dics2.Length; i++)
            }
        }

        private static void GetChildDirectoiresAndFiles(string path, List<string> dictList)//递归获取子目录所有文件列表 
        {
            DirectoryInfo dict = new DirectoryInfo(path);

            DirectoryInfo[] dicts = dict.GetDirectories();
            FileInfo[] files = dict.GetFiles();

            dictList.AddRange(files.Select(f => f.FullName));

            foreach (var dic in dicts)
            {
                dictList.Add(dic.FullName);
                GetChildDirectoiresAndFiles(dic.FullName, dictList);
            }
        }
    }
}
