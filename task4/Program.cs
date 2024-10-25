using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 输入文件路径
            string filePath = @"E:\2539737530\FileRecv\file.txt"; // 修改为你的文件路径

            try
            {
                // 检查文件是否存在
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("未找到指定的文件: " + filePath);
                    return;
                }

                // 读取文件字节
                byte[] fileBytes = File.ReadAllBytes(filePath);

                // 输出字节到命令行
                Console.WriteLine("文件字节内容:");
                foreach (byte b in fileBytes)
                {
                    Console.Write(b + " ");
                }

                Console.WriteLine(); // 换行
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生错误: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
