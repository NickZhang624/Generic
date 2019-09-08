using System;
//泛型算法的例子
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3};
            int[] a2 = { 1, 2, 3, 4 };
            double[] a3 = { 1, 2, 3, 4, 5 };
            double[] a4 = { 1, 2, 3, 4, 5,6 };

            var result = Zip(a1, a2);
            Console.WriteLine(String.Join(",",result));
            // 如果要Zip变成 a3，a4就不行了，因为是dboule 的类型，变动如下：

            /*static T[] Zip<T>(T[] a, T[] b)
            {
                T[] zippped = new T[a.Length + b.Length];
                int ai = 0, bi = 0, zi = 0;
                do
                {
                    if (ai < a.Length) zippped[zi++] = a[ai++];
                    if (bi < b.Length) zippped[zi++] = b[bi++];
                } while (ai < a.Length || bi < b.Length);
                return zippped;
            }*/

        }

        static int[] Zip(int[] a, int[] b)
        {
            int[] zippped = new int[a.Length + b.Length];
            int ai = 0, bi = 0, zi = 0;
            do
            {
                if (ai < a.Length) zippped[zi++] = a[ai++];
                if (bi < b.Length) zippped[zi++] = b[bi++];
            } while (ai < a.Length || bi < b.Length);
            return zippped;
        }
    }

   
}
