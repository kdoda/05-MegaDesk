namespace MegaDesk
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addNewQuote = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddNewQuotes = new System.Windows.Forms.Button();
            this.buttonViewQuotes = new System.Windows.Forms.Button();
            this.buttonSearchQuotes = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewQuote
            // 
            this.addNewQuote.Location = new System.Drawing.Point(12, 73);
            this.addNewQuote.Name = "addNewQuote";
            this.addNewQuote.Size = new System.Drawing.Size(0, 0);
            this.addNewQuote.TabIndex = 0;
            this.addNewQuote.Text = "Add New Quote";
            this.addNewQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAddNewQuotes
            // 
            this.buttonAddNewQuotes.Location = new System.Drawing.Point(36, 47);
            this.buttonAddNewQuotes.Name = "buttonAddNewQuotes";
            this.buttonAddNewQuotes.Size = new System.Drawing.Size(148, 50);
            this.buttonAddNewQuotes.TabIndex = 5;
            this.buttonAddNewQuotes.Text = "Add New Quotes";
            this.buttonAddNewQuotes.UseVisualStyleBackColor = true;
            this.buttonAddNewQuotes.Click += new System.EventHandler(this.buttonAddNewQuotes_Click);
            // 
            // buttonViewQuotes
            // 
            this.buttonViewQuotes.Location = new System.Drawing.Point(36, 117);
            this.buttonViewQuotes.Name = "buttonViewQuotes";
            this.buttonViewQuotes.Size = new System.Drawing.Size(148, 50);
            this.buttonViewQuotes.TabIndex = 6;
            this.buttonViewQuotes.Text = "View Quotes";
            this.buttonViewQuotes.UseVisualStyleBackColor = true;
            this.buttonViewQuotes.Click += new System.EventHandler(this.buttonViewQuotes_Click);
            // 
            // buttonSearchQuotes
            // 
            this.buttonSearchQuotes.Location = new System.Drawing.Point(36, 191);
            this.buttonSearchQuotes.Name = "buttonSearchQuotes";
            this.buttonSearchQuotes.Size = new System.Drawing.Size(148, 50);
            this.buttonSearchQuotes.TabIndex = 7;
            this.buttonSearchQuotes.Text = "Search Quotes";
            this.buttonSearchQuotes.UseVisualStyleBackColor = true;
            this.buttonSearchQuotes.Click += new System.EventHandler(this.buttonSearchQuotes_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(36, 261);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(148, 50);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSearchQuotes);
            this.Controls.Add(this.buttonViewQuotes);
            this.Controls.Add(this.buttonAddNewQuotes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addNewQuote);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addNewQuote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddNewQuotes;
        private System.Windows.Forms.Button buttonViewQuotes;
        private System.Windows.Forms.Button buttonSearchQuotes;
        private System.Windows.Forms.Button buttonExit;
    }
}

