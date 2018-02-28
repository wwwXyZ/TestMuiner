using System;
using System.Collections.Generic;
using System.Text;

namespace TestMuiner
{
    class Program
    {
        static void Main(string[] args)
        {
            var sysInfo = new SysInfo();
            sysInfo.getSysInfo();
            System.Console.ReadKey();
            
        }
    }
}
