using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StorageMedia> storagemedia = new List<StorageMedia>();

            storagemedia.Add(new Blu_ray(25, 12, "One layer Blu-ray", "MPEG-2"));
            storagemedia.Add(new Blu_ray(50, 20, "Dual layer Blu-ray", "MPEG-4"));
            storagemedia.Add(new FloppyDisk(0.0012, 0.0005, "5¼ Floppy", true));
            storagemedia.Add(new FloppyDisk(0.00072, 0.0005, "5¼ Floppy", true));
            storagemedia.Add(new Ssd(256, 200, "Intel SSD", "SandForce"));
            storagemedia.Add(new Ssd(512, 20, "Micron SSD", "SandForce"));

            foreach (StorageMedia storagemedia1 in storagemedia)
            {
                Console.WriteLine(storagemedia1.ToString());
                storagemedia1.FreeSpace();
            }
        }
    }
}
