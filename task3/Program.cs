using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 输入文件路径和输出文件路径
            string inputFilePath = @"E:\2539737530\FileRecv\inputFile.txt"; // 修改为你的输入文件路径
            string outputFilePath = @"E:\2539737530\FileRecv\outputFile.txt"; // 修改为你的输出文件路径

            try
            {
                // 确保输出文件路径是空的，如果已经存在可以选择是否覆盖
                if (File.Exists(outputFilePath))
                {
                    File.Delete(outputFilePath); // 删除已存在的文件
                }

                // 逐行读取输入文件
                using (StreamReader sr = new StreamReader(inputFilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // 将每一行写入输出文件
                        File.AppendAllText(outputFilePath, line + Environment.NewLine);
                    }
                }

                Console.WriteLine("文件内容已逐行成功复制到: " + outputFilePath);
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
