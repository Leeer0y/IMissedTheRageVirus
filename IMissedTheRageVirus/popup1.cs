using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMissedTheRageVirus
{
    public partial class popup1 : Form
    {
        public popup1()
        {
            InitializeComponent();
        }

        Random r;
        Timer t;

        private void popup1_Load(object sender, EventArgs e)
        {
            r = new Random();

            this.Location = new Point(r.Next(Screen.PrimaryScreen.Bounds.Width),
                r.Next(Screen.PrimaryScreen.Bounds.Height)); //Init location spawns anywhere winthin the primary screen bounds

            t = new Timer();
            t.Interval += 100;
            t.Tick += T_tick;
            t.Start();
        }

        private void T_tick(object sender, EventArgs e)
        {
            // Moves the form windows around randomly
            this.Left += r.Next(-4, 4);
            this.Top += r.Next(-4, 4);
        }
    }
}
