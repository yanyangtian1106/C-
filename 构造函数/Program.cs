using System;

namespace 构造函数//用来初始化数据,无返回值
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 str = new Class1();//有多个构造函数时，构造函数会自己调用对应匹配的函数
            str.Show();


            Class1 yyt = new Class1("晏阳天", "双流", 20, "2021年");
            yyt.Show();

        }
    }
}
