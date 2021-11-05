using System;
using System.Windows.Forms;
using System.IO;

namespace StickyNotex
{
    public partial class AddStickyNote : Form
    {
        public AddStickyNote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbnotes.Text == "") // if there is no text
            {
                MessageBox.Show("there is nothing to save "); // messagebox for warning
            }
            else if (txbnotes.Text != "") // if there is text
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "notes\\"; // sets a string to locate the user name, and location to the ,atj
                DirectoryInfo di = Directory.CreateDirectory(path); // creates the folder
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "notes\\" + "notes.txt"; // string that gets the path, allocated to the documents folder
                StreamWriter Notes = new StreamWriter(folder, append:true); // declares the streamwriter, file location and allowing it to overwrite
                string notes = txbnotes.Text; // string uses the txbnotes.text for the stringtext
                Notes.WriteLine(notes); // writes the text
                Notes.Close(); // closes the streamwriter
                MessageBox.Show("Your note has been saved.", "Succes!"); // messagebox for succes
                Mainform goback = new Mainform(); // declaring the form to a variable
                goback.Show(); //using the variable to show the form
                this.Close(); // hides the form

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "notes\\"; // sets a string to locate the user name, and location to the ,atj
            DirectoryInfo di = Directory.CreateDirectory(path); // creates the folder
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "notes\\" + "notes.txt"; // stri
            File.WriteAllText(folder, string.Empty); // clears all the test
            MessageBox.Show("Everything has been erased!", "succes"); //messagebox for succes
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mainform goback = new Mainform(); // declaring the form to a variable
            goback.Show(); //using the variable to show the form
            this.Close(); // hides the form
        }
    }
}
