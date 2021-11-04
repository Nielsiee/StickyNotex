using System;
using System.IO;
using System.Windows.Forms;

namespace StickyNotex
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStickyNote addreminder = new AddStickyNote(); // declaring the form to a variable
            addreminder.Show(); // shows the form
            this.Close();// closes the form
            this.Dispose();// removes everything which is active

        }



   

        private void Mainform_Load(object sender, EventArgs e)
        {
                //process start : onload form start searching for left notes 
                FileInfo fi = new FileInfo("notes.txt");   // declaring fileinfo to the file
                FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read); // declaring filestream to allow the streamreader to work
                StreamReader sr = new StreamReader(fs); //declaring the streamreader and using the variable
                string fileContent = sr.ReadToEnd(); //reads all the file content
                lblNotes.Text = fileContent; // sets the labeltext to the string
                sr.Close(); // closing streamreader
                fs.Close(); // closes filestream
                // ends process
            if(lblNotes.Text == "") // if statement for checking if there is already text imported
            {
                lblNotes.Text = "Start adding notes by pressing 'add a new note' "; // sets the standard text
            }
        }
    }
}
