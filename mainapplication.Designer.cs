namespace StickyNotex
{
    partial class mainapplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainapplication));
            this.addNote = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.deletenote = new System.Windows.Forms.Button();
            this.welcometxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addNote
            // 
            this.addNote.BackColor = System.Drawing.Color.Green;
            this.addNote.Location = new System.Drawing.Point(28, 532);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(471, 117);
            this.addNote.TabIndex = 0;
            this.addNote.Text = "Add a note!";
            this.addNote.UseVisualStyleBackColor = false;
            this.addNote.Click += new System.EventHandler(this.addNote_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNotes.Location = new System.Drawing.Point(25, 124);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(474, 382);
            this.lblNotes.TabIndex = 1;
            // 
            // deletenote
            // 
            this.deletenote.BackColor = System.Drawing.Color.Red;
            this.deletenote.Location = new System.Drawing.Point(28, 655);
            this.deletenote.Name = "deletenote";
            this.deletenote.Size = new System.Drawing.Size(471, 118);
            this.deletenote.TabIndex = 3;
            this.deletenote.Text = "Delete your notes";
            this.deletenote.UseVisualStyleBackColor = false;
            this.deletenote.Click += new System.EventHandler(this.deletenote_Click);
            // 
            // welcometxt
            // 
            this.welcometxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcometxt.Location = new System.Drawing.Point(88, 24);
            this.welcometxt.Name = "welcometxt";
            this.welcometxt.Size = new System.Drawing.Size(352, 90);
            this.welcometxt.TabIndex = 4;
            this.welcometxt.Text = "Welcome to Sticky notes!";
            // 
            // mainapplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 794);
            this.Controls.Add(this.welcometxt);
            this.Controls.Add(this.deletenote);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.addNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainapplication";
            this.Load += new System.EventHandler(this.mainapplication_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button deletenote;
        private System.Windows.Forms.Label welcometxt;
    }
}