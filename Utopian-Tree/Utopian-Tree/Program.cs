using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopian_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = 0;
            int height = 1;

            int n = 10;
            for(int i=0; i<n; i++)
            {
                if (i % 2 == 0)
                {
                    height *= 2;
                }
                else
                {
                    height += 1;
                }
            }
            Console.WriteLine(height);
            Console.ReadKey();

        }
    }
}
