using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int h;
            Console.WriteLine("Nhập vào chiều cao: ");
            h = int.Parse(Console.ReadLine());
            for (int row = 0; row < h; row++)
            {
                for(int col = 0; col  < h; col++)
                {
                    if (col <= row)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
