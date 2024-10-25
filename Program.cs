using System;
using System.IO;

class DXFReader
{
    static void Main(string[] args)
    {
        
        string dxfFilePath = @"E:\2539737530\FileRecv\dxf-practice.dxf"; // 从控制台读取文件路径

        // 检查指定的 DXF 文件是否存在
        if (!File.Exists(dxfFilePath))
        {
            Console.WriteLine("找不到文件: " + dxfFilePath);
            return; // 如果文件不存在，输出错误并退出
        }

        try
        {
            // 使用 StreamReader 逐行读取 DXF 文件
            using (StreamReader reader = new StreamReader(dxfFilePath))
            {
                string line;
                bool insideEntitiesSection = false; // 标记是否在 ENTITIES 段

                // 循环逐行读取文件内容
                while ((line = reader.ReadLine()) != null)
                {
                    // 去除行的前后空格
                    line = line.Trim();

                    // 检查是否开始 ENTITIES 段
                    if (line.Equals("0", StringComparison.OrdinalIgnoreCase))
                    {
                        line = reader.ReadLine()?.Trim(); // 读取下一行
                        if (line != null && line.Equals("ENTITIES", StringComparison.OrdinalIgnoreCase))
                        {
                            insideEntitiesSection = true; // 进入 ENTITIES 段
                            continue; // 继续读取下一行
                        }
                    }

                    // 检查是否结束 ENTITIES 段
                    if (insideEntitiesSection && line.Equals("0", StringComparison.OrdinalIgnoreCase))
                    {
                        line = reader.ReadLine()?.Trim(); // 读取下一行
                        if (line != null && line.Equals("ENDSEC", StringComparison.OrdinalIgnoreCase))
                        {
                            break; // 找到段结束，退出循环
                        }
                    }

                    // 如果在 ENTITIES 段内，输出当前行内容
                    if (insideEntitiesSection)
                    {
                        Console.WriteLine(line); // 输出 ENTITIES 段内容
                        Console.ReadKey();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // 捕获并输出异常错误信息
            Console.WriteLine("发生错误: " + ex.Message);
        }
    }
}

