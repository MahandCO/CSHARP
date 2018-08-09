namespace MyApplication
{
    partial class BooksList
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
            this.bookNameLabel = new Dtx.Windows.Forms.Label();
            this.bookNameTextbox = new Dtx.Windows.Forms.TextBox();
            this.searchButton = new Dtx.Windows.Forms.Button();
            this.aboutBookTextbox = new Dtx.Windows.Forms.TextBox();
            this.booksListBox = new Dtx.Windows.Forms.ListBox();
            this.label1 = new Dtx.Windows.Forms.Label();
            this.label2 = new Dtx.Windows.Forms.Label();
            this.activeCheckBox = new Dtx.Windows.Forms.CheckBox();
            this.saveButton = new Dtx.Windows.Forms.Button();
            this.addNewButton = new Dtx.Windows.Forms.Button();
            this.thoughtOutCheckBox = new Dtx.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(13, 13);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(82, 13);
            this.bookNameLabel.TabIndex = 0;
            this.bookNameLabel.Text = "&Book Name :";
            // 
            // bookNameTextbox
            // 
            this.bookNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookNameTextbox.Location = new System.Drawing.Point(138, 10);
            this.bookNameTextbox.Name = "bookNameTextbox";
            this.bookNameTextbox.Size = new System.Drawing.Size(353, 21);
            this.bookNameTextbox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(497, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "&Go";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // aboutBookTextbox
            // 
            this.aboutBookTextbox.Location = new System.Drawing.Point(138, 113);
            this.aboutBookTextbox.Multiline = true;
            this.aboutBookTextbox.Name = "aboutBookTextbox";
            this.aboutBookTextbox.Size = new System.Drawing.Size(434, 186);
            this.aboutBookTextbox.TabIndex = 4;
            // 
            // booksListBox
            // 
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.Location = new System.Drawing.Point(138, 38);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(434, 69);
            this.booksListBox.TabIndex = 5;
            this.booksListBox.SelectedIndexChanged += new System.EventHandler(this.booksListBox_SelectedIndexChanged);
            this.booksListBox.DoubleClick += new System.EventHandler(this.booksListBox_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "&Books List :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selected Book Info :";
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(12, 227);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(61, 17);
            this.activeCheckBox.TabIndex = 8;
            this.activeCheckBox.Text = "&Active";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 276);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(12, 251);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(119, 23);
            this.addNewButton.TabIndex = 10;
            this.addNewButton.Text = "&Add New";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // thoughtOutCheckBox
            // 
            this.thoughtOutCheckBox.AutoSize = true;
            this.thoughtOutCheckBox.Location = new System.Drawing.Point(12, 204);
            this.thoughtOutCheckBox.Name = "thoughtOutCheckBox";
            this.thoughtOutCheckBox.Size = new System.Drawing.Size(96, 17);
            this.thoughtOutCheckBox.TabIndex = 11;
            this.thoughtOutCheckBox.Text = "&Thought Out";
            this.thoughtOutCheckBox.UseVisualStyleBackColor = true;
            // 
            // BooksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.thoughtOutCheckBox);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.aboutBookTextbox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.bookNameTextbox);
            this.Controls.Add(this.bookNameLabel);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "BooksList";
            this.Text = "BooksList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dtx.Windows.Forms.Label bookNameLabel;
        private Dtx.Windows.Forms.TextBox bookNameTextbox;
        private Dtx.Windows.Forms.Button searchButton;
        private Dtx.Windows.Forms.TextBox aboutBookTextbox;
        private Dtx.Windows.Forms.ListBox booksListBox;
        private Dtx.Windows.Forms.Label label1;
        private Dtx.Windows.Forms.Label label2;
        private Dtx.Windows.Forms.CheckBox activeCheckBox;
        private Dtx.Windows.Forms.Button saveButton;
        private Dtx.Windows.Forms.Button addNewButton;
        private Dtx.Windows.Forms.CheckBox thoughtOutCheckBox;
    }
}