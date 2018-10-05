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

        private void cmd(string command)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = command;
            process.StartInfo = startInfo;
            Process.Start(startInfo);
        }
        public int HandleTime()
        {
            string time;
            Console.WriteLine("Enter your designated time in Hours:Minuts");
            time = Console.ReadLine();
            string[] timer = time.Split(':');
            Hours = int.Parse(timer[0]);
            Minuts = int.Parse(timer[1]);
            int Seconds = Hours * 3600 + Minuts * 60;

            return Seconds;

        }

        public void SetTimer(int Duration)
        {
            cmd("/C shutdown -s -t " + Duration);

        }
        public void CancelTimer()
        {
            cmd("/C shutdown -a");
        }
        public void RestartPC()
        {
            cmd("/C shutdown -r");
        }
        public void ForceShutdown()
        {
            cmd("/C shutdown -s -f -t 00");
        }
    }
}
