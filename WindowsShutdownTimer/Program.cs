using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SmartMenuLibrary;

namespace Shutdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Bindings binding = new Bindings();
            Timer Mytimer = new Timer();
            binding.bind("1", SetTimer);
            binding.bind("2", CancelTimer);
            binding.bind("3", RestartPC);
            binding.bind("4", ForceShutdown);
            binding.bind("5", Exit);

            SmartMenu menu = new SmartMenu(binding);
            menu.LoadMenu("menu.txt");
            menu.Activate();

            void SetTimer()
            {
                int duration;
                duration = Mytimer.HandleTime();
                Mytimer.SetTimer(duration);
            }
            void CancelTimer()
            {
                Mytimer.CancelTimer();
            }
            void RestartPC()
            {
                Mytimer.RestartPC();
            }
            void ForceShutdown()
            {
                Mytimer.ForceShutdown();
            }
            void Exit()
            {
                Environment.Exit(1);
            }

        }
        
        
    }
}
