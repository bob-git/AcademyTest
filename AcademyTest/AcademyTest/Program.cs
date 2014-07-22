using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTest
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("current date {0}", new Program().PrintDateFormatted());
        }
        
        public string PrintDateFormatted()
        {
            return DateTime.Now.ToString();
        }
    }
}
