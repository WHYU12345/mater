using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p = new Person();

            Console.WriteLine(p.Run());
            Console.WriteLine(p.Say());
            
        }

        interface Action
        {
            string Run();
            string Say();
        }


        class Person : Action
        {
            public string Run()
            {
                return "我在跑";
            }

            public string Say()
            {
                return "我在说话";
            }

        }
        //接口可以继承使用  不能实例化 接口抽象行为



    }
}
