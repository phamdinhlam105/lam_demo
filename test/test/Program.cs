using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0;
            string n ;
            //System.Console.WriteLine("Hello World, this is test file, give a number");
            //string doc;
            //doc = Console.ReadLine();
            test.Program.xinchao(); //call method
            Console.WriteLine("Chon phep tinh ( cong, tru, nhan, chia)");

            n = Console.ReadLine();

            Console.WriteLine("nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("a = {0}", a);
            
            Console.WriteLine("nhap b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("b = {0}", b);
            switch (n){
                case "cong": Console.WriteLine("a + b = {0}", Tinhtoan.cong(a, b));
                    break;
                case "tru":
                    Console.WriteLine("a - b= {0}", Tinhtoan.tru(a, b));
                    break;
                case "nhan":
                    Console.WriteLine("a x b = {0}", Tinhtoan.nhan(a, b));
                    break;
                case "chia":
                    Console.WriteLine("a : b = {0}", Tinhtoan.chia(a, b));
                    break;
                default:
                    Console.WriteLine("sai phep tinh roi");
                    break;
            }

            Console.ReadKey();
        }
        //method
        static void xinchao()
        {
            Console.WriteLine("hello, this is a calculator");

        }
    }
}
