
namespace StickyNotex
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.lblNotes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.movefrmleft = new System.Windows.Forms.Button();
            this.btnmoveright = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotes
            // 
            this.lblNotes.Location = new System.Drawing.Point(5, 9);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(518, 411);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(139, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add a new note";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(139, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // movefrmleft
            // 
            this.movefrmleft.BackColor = System.Drawing.Color.Blue;
            this.movefrmleft.Location = new System.Drawing.Point(8, 453);
            this.movefrmleft.Name = "movefrmleft";
            this.movefrmleft.Size = new System.Drawing.Size(114, 109);
            this.movefrmleft.TabIndex = 3;
            this.movefrmleft.Text = "Move the application to the left";
            this.movefrmleft.UseVisualStyleBackColor = false;
            this.movefrmleft.Click += new System.EventHandler(this.movefrmleft_Click);
            // 
            // btnmoveright
            // 
            this.btnmoveright.BackColor = System.Drawing.Color.Blue;
            this.btnmoveright.Location = new System.Drawing.Point(399, 453);
            this.btnmoveright.Name = "btnmoveright";
            this.btnmoveright.Size = new System.Drawing.Size(114, 109);
            this.btnmoveright.TabIndex = 4;
            this.btnmoveright.Text = "Move the application to the right";
            this.btnmoveright.UseVisualStyleBackColor = false;
            this.btnmoveright.Click += new System.EventHandler(this.btnmoveright_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(139, 423);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 39);
            this.button4.TabIndex = 6;
            this.button4.Text = "Move Form to other screen";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 574);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnmoveright);
            this.Controls.Add(this.movefrmleft);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.Text = "StickyNoteX";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button movefrmleft;
        private System.Windows.Forms.Button btnmoveright;
        private System.Windows.Forms.Button button4;
    }
}

