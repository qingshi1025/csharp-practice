using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 输入源文件路径
            string sourceFilePath = @"E:\2539737530\FileRecv\file.txt"; // 修改为你的源文件路径

            try
            {
                // 检查源文件是否存在
                if (!File.Exists(sourceFilePath))
                {
                    Console.WriteLine("未找到指定的源文件: " + sourceFilePath);
                    return;
                }

                // 读取源文件的字节并每10字节输出
                using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[10];
                    int bytesRead;

                    while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        // 输出读取的字节为可读字符串
                        string output = BitConverter.ToString(buffer, 0, bytesRead).Replace('-', ' ');
                        Console.WriteLine(output);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生错误: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
