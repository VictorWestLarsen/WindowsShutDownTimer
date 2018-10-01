using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Shutdown
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader menu = new StreamReader("Menu.txt"))
            {
                string line;
                while ((line = menu.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Timer SleepTimer = new Timer();
                    int Duration = SleepTimer.HandleTime();
                    SleepTimer.SetTimer(Duration);
                    Console.WriteLine("Computeren Slukker om: " + SleepTimer.Hours + " time(r) og " + SleepTimer.Minuts + " Minut(er)");
                    Console.ReadKey();

                }
            }
        }
    }
}
