using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banner
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            //increment the progress bar
            loadingProgressBar.Increment(1);
            if (loadingProgressBar.Value == 100)
            {
                //stop the splash screen timer
                splashScreenTimer.Stop();
            }
        }
    }
}
