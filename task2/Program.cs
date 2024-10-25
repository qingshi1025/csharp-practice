using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 输入文件路径和输出文件路径
            string inputFilePath = @"E:\2539737530\FileRecv\inputFile.txt"; // 更改为你的输入文件路径
            string outputFilePath = @"E:\2539737530\FileRecv\outputFile.txt"; // 更改为你的输出文件路径

            try
            {
                // 读取输入文件内容
                string content = File.ReadAllText(inputFilePath);

                // 将内容写入输出文件
                File.WriteAllText(outputFilePath, content);

                Console.WriteLine("文件内容已成功复制到: " + outputFilePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("未找到指定的输入文件: " + inputFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生错误: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
