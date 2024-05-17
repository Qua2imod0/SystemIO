﻿using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace SystemIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path1 = "D:\\Csharp";
            String[] dics1 = Directory.GetDirectories(path1); //获取子目录文件夹列表
            for (int i = 0; i < dics1.Length; i++)
            {
                Console.WriteLine(dics1[i]);
            }

            Console.WriteLine("----------------------------");

            String path2 = "D:\\Csharp";
            String[] dics2 = Directory.GetFiles(path2);//获取子目录文件列表
            for (int i = 0; i < dics2.Length; i++)
            {
                Console.WriteLine(dics2[i]);
            }

        }

        private static void GetChildDirectoiresAndFiles(string path, List<string> dictList)
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