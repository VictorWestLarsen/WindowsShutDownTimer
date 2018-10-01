using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Shutdown
{
    class Timer
    {
        public int Hours = 0;
        public int Minuts = 0;
        public Timer()
        {

        }
        public int HandleTime()
        {
            string time;
            Console.WriteLine("Indtast tid til lukning som følgende eksempel timer:minutter");
            time = Console.ReadLine();
            string[] timer = time.Split(':');
            Hours = int.Parse(timer[0]);
            Minuts = int.Parse(timer[1]);
            int Seconds = Hours * 3600 + Minuts * 60;

            return Seconds;

        }

        public void SetTimer(int Duration)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -s -t" + Duration;
            process.StartInfo = startInfo;
            Process.Start(startInfo);

        }
    }
}
