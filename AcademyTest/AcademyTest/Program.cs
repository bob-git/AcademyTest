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
            Console.WriteLine("current date {0}", new Program().PrintDate());
        }

        public DateTime PrintDate()
        {
            return DateTime.Now;
        }
    }
}
