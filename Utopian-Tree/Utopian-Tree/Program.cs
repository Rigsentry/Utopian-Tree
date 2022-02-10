using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopian_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new int[3] { 0, 1, 4 };
            var b = new int[3] { 6, 5, 4 };
            procUtopianTree(a);
            Console.ReadKey();

        }

        public static void procUtopianTree(int[] n)
        {
            foreach (var item in n)
            {
                Console.WriteLine(utopianTree(item));
            }
        }

        public static int utopianTree(int n)
        {
            int height = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    height += 1;
                else
                    height = height *2;
            }
            return height;
        }
    }
}
