using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Получить новый файл из однозначных элементов исходного.

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader T1 = new StreamReader("first.txt");
            StreamWriter T2 = new StreamWriter("last.txt");
            int a, b;
            while (!T1.EndOfStream)
            {
                a = int.Parse(T1.ReadLine());
                b = Math.Abs(a);
                if (b<10 && b>-10)
                {
                    T2.WriteLine(a);
                }
            }
            T1.Close();
            T2.Close();
        }
    }
}
