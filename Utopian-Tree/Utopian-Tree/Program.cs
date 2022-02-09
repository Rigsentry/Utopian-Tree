using System;

namespace Utopian_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            GrowTree(0);
            GrowTree(1);
            GrowTree(4);

            GrowTree(6);
            GrowTree(5);
            GrowTree(4);
        }
        static void GrowTree(int n)
        {
            var height = 1;
            for(int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    height = height + 1;
                }
                else
                {
                    height = height * 2;
                }
            }
            Console.WriteLine(height);
        }
    }
}
