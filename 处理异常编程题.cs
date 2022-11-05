using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_笔记
{
    class 处理异常编程题
    {
        static void Main(string [] args)
        {
            Console.WriteLine("请输入两个数字,每行一个");

            int n1 = 0;
            int n2 = 0;
            //try
            //{
            // n1 = Convert.ToInt32(Console.ReadLine());
            // n2 = Convert.ToInt32(Console.ReadLine());
            //}
            //catch(FormatException e)//出现格式化异常，说明用户输入非法数据
            //{
            //    Console.WriteLine("你输入的数据不符合规则，请重新输入");
            //     n1 = Convert.ToInt32(Console.ReadLine());
            //     n2 = Convert.ToInt32(Console.ReadLine());
            //}

            while(true)
            {
                try//如果出现问题就进入catch，如果不出现问题就不用进入catch
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException e)//出现格式化异常，说明用户输入非法数据
                {
                    Console.WriteLine("你输入的数据不符合规则，请重新输入");
                }
            }
            Console.WriteLine(n1 + n2);
        }
    }
}
