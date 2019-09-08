using System;
/*泛型（Generic）
 * 泛型的意思就是Generic,它所代表的是通用类型,可以代替任意的数据类型,使得类型参数化,从而达到了只需要一个方法就可以操作多种数据的目的
 * 泛型与其他都有正交性
 * 例子如下：假如我是小商店的店主，买苹果，送一个装苹果的盒子，生意扩展后就开始卖书了
 * 卖书的话就需要另外增加一个装书的盒子，那么问题来了，如果有一千种商品的话那就需要1000个商品的class，1000个装盒子的class，如下：
 * 
 * 用泛型去解决，重新声明一个泛型类 class Box<>
 */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple a = new Apple() { Color = "red" };
            AppleBox ab = new AppleBox() { Cargo = a };
            Console.WriteLine(ab.Cargo.Color);

            Book b = new Book() { name = "Love u " };
            BookBox bb = new BookBox() { Cargo = b };
            Console.WriteLine(bb.Cargo.name);

            //泛型解决方案, <这里面这个在这个例子里面是叫泛型参数>
            Box<Apple> box1 = new Box<Apple>() { Cargo = a };
            Box<Book> box2 = new Box<Book>() { Cargo = b };
            Console.WriteLine(box1.Cargo.Color);
            Console.WriteLine(box2.Cargo.name);

        }
    }

    class Apple
    {
        public String Color { get; set; }
    }

    class AppleBox
    {
        public Apple Cargo { get; set; }
    }

    class Book
    {
        public string name { get; set; }
    }

    class BookBox
    {
        public Book Cargo { get; set; }

    }

    //泛型类。<T+名字>
    class Box<TCargo>
    {
        public TCargo Cargo { get; set; }
    }
}
