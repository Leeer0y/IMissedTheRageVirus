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
    public partial class msgBox : Form
    {
        static string fartDir = System.IO.Path.GetFullPath(@"..\..\resources\sounds\fartNoise.wav");

        public msgBox()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msgBox_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            this.Location = new Point(r.Next(Screen.PrimaryScreen.Bounds.Width),
                r.Next(Screen.PrimaryScreen.Bounds.Height));
        }
    }
}
