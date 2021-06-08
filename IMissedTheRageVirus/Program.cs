using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

using System.Windows;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace IMissedTheRageVirus
{
    class Program
    {
        private static System.Timers.Timer msgTimer;

        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();

            msgTimer = new System.Timers.Timer();
            msgTimer.Interval = 200;

            msgTimer.Elapsed += msgSpam;
            msgTimer.AutoReset = true;
            msgTimer.Enabled = true;

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.IMissedTheRage1);
            player.Play();

            
            Console.WriteLine("Press the Enter key to exit anytime... ");
            Console.ReadLine();
        }

        private static void msgSpam(Object source, System.Timers.ElapsedEventArgs e)
        {
            msgBox messageBox = new msgBox();
            messageBox.ShowDialog();

        }

    }
}
