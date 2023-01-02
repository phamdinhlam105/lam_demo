using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Tinhtoan
    {
        public static int cong(int a, int b)
        {
            return a + b;
        }
        public static int tru(int a, int b)
        {
            return a - b;
        }
        public static int nhan(int a, int b)
        {
            return a * b;
        }
        public static float chia(int a, int b)
        {
            if(b==0)
            {
                Console.WriteLine("ko chia duoc");
                return 0; }    
               
            else
                return (float)a / b;
        }
    }
}
