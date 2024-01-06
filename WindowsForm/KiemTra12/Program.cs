using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int h;
            Console.WriteLine("Nhập vào chiều cao: ");
            h = int.Parse(Console.ReadLine());

            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < h * 2 - 1; col++)
                {
                    if (col == 0 || (row == h - 1 && col < h - 1) || col == row || col == h - 1 || (row == 0 && col >= h) || col == 2 * h - 2 || col == h - 1 + row)


                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                    

                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
