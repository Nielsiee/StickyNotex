using System;
using System.Windows.Forms;

namespace StickyNotex
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2); // adds 2% to the progressbar
            if (progressBar1.Value == 100) // if statement for the progressbar being finished
            {
                timer1.Stop(); // stops the countdown timer
                Mainform sticky = new Mainform(); // declaring the form to a variable
                sticky.Show(); //using the variable to show the form
                this.Hide(); // hides the form
            
            }
        }

    }
}
