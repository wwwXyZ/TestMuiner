using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace TestMuiner
{
    class SysInfo
    {
        private int cpu_cores { get; set; }
        private int useMinerType;
        
        public void getSysInfo()
        {
            int coreCount = 0;
            foreach (var item in new ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }
            cpu_cores = coreCount;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

            string graphicsCard = string.Empty;
            foreach (ManagementObject mo in searcher.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                        graphicsCard = property.Value.ToString();
                    }
                }
            }
            Console.WriteLine(graphicsCard); //todo: set useMinerType by video card https://aikapool.com/aur/index.php?page=gettingstarted
        }
        
    }
}
