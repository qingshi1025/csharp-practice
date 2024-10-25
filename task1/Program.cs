using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"E:\2539737530\FileRecv\file.txt"; // 替换为你的文件路径

            try
            {
                // 读取文件内容
                string content = File.ReadAllText(filePath);

                // 输出到命令行
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("未找到指定的文件: " + filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生错误: " + ex.Message);
            }
            Console.ReadKey();
           
        }
    }
}
