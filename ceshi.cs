//保存为 TestSync.cs，编码格式选 UTF-8
using System;

namespace GitHubSyncTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 核心测试变量（你可以在A/B电脑互相修改）
            string syncTestMsg = "B电脑测试：GitHub同步成功！";
            int testNum = 99;

            // 输出测试信息
            Console.WriteLine("===== GitHub 跨电脑同步测试 =====");
            Console.WriteLine($"测试消息：{syncTestMsg}");
            Console.WriteLine($"测试数字：{testNum}，翻倍后:{testNum * 2}");
            Console.WriteLine($"当前运行设备：B电脑 | 运行时间：{DateTime.Now}");

            // 暂停窗口，方便查看结果
            Console.WriteLine("\n按任意键退出...");
            Console.ReadKey();
        }
    }
}