using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào chuỗi của bạn: ");
            string str = Console.ReadLine();
            Dictionary<string, int> myString = new Dictionary<string, int>();

            for (int i = 0; i < str.Length; i++)
            {
                string item = str[i].ToString().ToLower();

                if (myString.ContainsKey(item))
                {
                    myString[item]++;
                }
                else
                {
                    myString[item] = 1;
                }
            }

            int max = 0;
            string res = "";
            foreach (var s in myString)
            {
                if (s.Value > max)
                {
                    max = s.Value;
                    res = s.Key;
                }
            }

            Console.WriteLine("Ký tự {0} xuất hiện nhiều nhất với số lần {1}",res,max);


            Console.ReadKey();
        
    }
    }
}
