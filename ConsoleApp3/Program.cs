using System;
using System.Collections.Generic;//泛型引用

// 泛型例子
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<t>: IList<t>
            //list实现了 ilist 的所有方法，所以有add和remove以及其他的
            IList<int> i = new List<int>();
            for(int a=0; a<100; a++)
            {
                i.Add(a);
            }

            foreach(var item in i)
            {
                Console.WriteLine(item);
            }


            //以下例子是泛型类带有两个parapmeter，

            IDictionary<int, String> id = new Dictionary<int, String>();

            id[1] = "nick";
            id[2] = "zhang";
            Console.WriteLine(id[1] +" "+ id[2]);

        }
    }
}
