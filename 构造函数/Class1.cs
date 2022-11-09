using System;
using System.Collections.Generic;
using System.Text;

namespace 构造函数
{
    class Class1
    {
        public string name;
        public string address;
        public int age;
        public string creatTime;
        public Class1()
        {
            Console.WriteLine("我是构造函数");
        }
        public Class1(string arg1,string arg2,int arg3,string arg4)
        {
            name = arg1;
            address = arg2;
            age = arg3;
            creatTime = arg4;
        }
        public void Show()
        {
            Console.WriteLine("姓名：" + name);
            Console.WriteLine("地址：" + address);
            Console.WriteLine("年龄:" + age);
            Console.WriteLine("创建时间：" + creatTime);
        }
    } 

}
