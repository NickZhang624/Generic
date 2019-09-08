using System;
/*泛型接口的例子
 * 
 */
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student<int> s = new Student<int>();
            s.ID = 101;
            s.Name = "nick";
            Console.WriteLine(s.ID + " name is " + s.Name);
        }
    }

    interface IUnique<TId>
    {
        TId ID { get; set; }
    }

    //如果一个类继承的是泛型接口，那么这个类依然是泛型类
    class Student<TId> : IUnique<TId>
    {
        public TId ID { get; set; }
        public string Name { get; set; }
    }
}
