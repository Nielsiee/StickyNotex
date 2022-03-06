using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;
namespace StickyNotex
{
    public partial class mainapplication : Form
    {
        public mainapplication()
        {
            InitializeComponent();
        }

        private void mainapplication_Load(object sender, EventArgs e) // tells what the "application" to do on startup
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "notes\\"; // sets a string to locate the user name, and location to the ,atj
            DirectoryInfo di = Directory.CreateDirectory(path); // creates the folder
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "notes\\" + "notes.txt"; // string for putting up the folder location and the file
            FileInfo fi = new FileInfo(folder);   // declaring fileinfo to the file
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read); // declaring filestream to allow the streamreader to work
            StreamReader sr = new StreamReader(fs); //declaring the streamreader and using the variable
            string fileContent = sr.ReadToEnd(); //reads all the file content
            lblNotes.Text = fileContent; // sets the labeltext to the string
            sr.Close(); // closing streamreader
            fs.Close(); // closes filestream
                        // ends process
            if (lblNotes.Text == "") // if statement for checking if there is already text imported
            {
                lblNotes.Text = "Start adding notes by pressing 'add a new note' "; // sets the standard text
            }
        }

        private void addNote_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Add a note down below.", "Add", "You can type here.");
            if (input == "") // if there is no text
            {
                MessageBox.Show("there is nothing to save "); // messagebox for warning
            }
            else if (input != "") // if there is text
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "notes\\"; // sets a string to locate the user name, and location to the ,atj
                DirectoryInfo di = Directory.CreateDirectory(path); // creates the folder
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "notes\\" + "notes.txt"; // string that gets the path, allocated to the documents folder
                StreamWriter Notes = new StreamWriter(folder, append: true); // declares the streamwriter, file location and allowing it to overwrite
                string notes = input; // string uses the input from the visual basic inputbox for the stringtext
                Notes.WriteLine(notes); // writes the text
                Notes.Close(); // closes the streamwriter
                MessageBox.Show("Your note has been saved.", "Succes!"); // messagebox for succes
                Application.Restart(); // restarts application

            }
        }

        private void deletenote_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "notes\\"; // sets a string to locate the user name, and location to the ,atj
            DirectoryInfo di = Directory.CreateDirectory(path); // creates the folder
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "notes\\" + "notes.txt"; // string for the folder location
            File.WriteAllText(folder, string.Empty); // clears all the test
            MessageBox.Show("Everything has been erased!", "succes"); //messagebox for succes
            Application.Restart(); // restarts application
        }
    }
}
