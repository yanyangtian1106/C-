using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_笔记
{
    class 处理异常语句
    {
        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3, 4 };

            try//放可能出现异常的代码,try跟catch，finally配套使用,可以不用finally
            {
                int tmp = myArr[4];//可能出现异常的语句,猜测可能会出现数组下标越界的异常
            }
            catch (IndexOutOfRangeException e/*申明一个异常类型的一个对象*/)//代表要捕捉哪些异常
            {
                //代表出现这个异常的时候怎么处理
                Console.WriteLine("出现了数组下标越界异常");
            }
            catch (FieldAccessException e)//两个catch代表我们要捕捉两个异常
            {
                Console.WriteLine("出现了FieldAccessException异常");
            }
            finally//代表不管任何情况下都会执行的代码，不管出不出现异常，都会执行
            {
                Console.WriteLine("不管是否出现异常，都会执行");
            }
            Console.Write("23");


        }
    }
}
