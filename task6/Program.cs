using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 输入源文件路径和目标文件路径
            string sourceFilePath = @"E:\2539737530\FileRecv\inputFile.txt"; // 修改为你的源文件路径
            string destinationFilePath = @"E:\2539737530\FileRecv\outputFile.txt"; // 修改为你的目标文件路径

            try
            {
                // 检查源文件是否存在
                if (!File.Exists(sourceFilePath))
                {
                    Console.WriteLine("未找到指定的源文件: " + sourceFilePath);
                    return;
                }

                // 读取源文件的字节并逐10字节写入目标文件
                using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
                using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[10];
                    int bytesRead;

                    while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        // 将读取的字节写入目标文件
                        destinationStream.Write(buffer, 0, bytesRead);
                    }
                }

                Console.WriteLine("文件已成功处理并写入到目标文件。");
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生错误: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
