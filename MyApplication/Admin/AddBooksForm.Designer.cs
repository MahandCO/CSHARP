namespace MyApplication.Admin
{
    partial class AddBooksForm
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
            this.label1 = new Dtx.Windows.Forms.Label();
            this.bookNameTextBox = new Dtx.Windows.Forms.TextBox();
            this.booktypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new Dtx.Windows.Forms.Label();
            this.label3 = new Dtx.Windows.Forms.Label();
            this.aboutBookTextBox = new Dtx.Windows.Forms.TextBox();
            this.closeButton = new Dtx.Windows.Forms.Button();
            this.resetButton = new Dtx.Windows.Forms.Button();
            this.saveButton = new Dtx.Windows.Forms.Button();
            this.thoughtOutCheckBox = new Dtx.Windows.Forms.CheckBox();
            this.activeCheckBox = new Dtx.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Book Name :";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(100, 6);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(214, 21);
            this.bookNameTextBox.TabIndex = 0;
            // 
            // booktypeComboBox
            // 
            this.booktypeComboBox.FormattingEnabled = true;
            this.booktypeComboBox.Items.AddRange(new object[] {
            "Science",
            "Drama",
            "Romance",
            "Mystery",
            "Self help",
            "Health",
            "History"});
            this.booktypeComboBox.Location = new System.Drawing.Point(402, 6);
            this.booktypeComboBox.Name = "booktypeComboBox";
            this.booktypeComboBox.Size = new System.Drawing.Size(170, 21);
            this.booktypeComboBox.TabIndex = 1;
            this.booktypeComboBox.Text = "(Select Book Type)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Book Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&About Book :";
            // 
            // aboutBookTextBox
            // 
            this.aboutBookTextBox.Location = new System.Drawing.Point(100, 38);
            this.aboutBookTextBox.Multiline = true;
            this.aboutBookTextBox.Name = "aboutBookTextBox";
            this.aboutBookTextBox.Size = new System.Drawing.Size(472, 232);
            this.aboutBookTextBox.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(496, 276);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(415, 276);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(334, 276);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // thoughtOutCheckBox
            // 
            this.thoughtOutCheckBox.AutoSize = true;
            this.thoughtOutCheckBox.Location = new System.Drawing.Point(100, 280);
            this.thoughtOutCheckBox.Name = "thoughtOutCheckBox";
            this.thoughtOutCheckBox.Size = new System.Drawing.Size(96, 17);
            this.thoughtOutCheckBox.TabIndex = 7;
            this.thoughtOutCheckBox.Text = "&Thought Out";
            this.thoughtOutCheckBox.UseVisualStyleBackColor = true;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(202, 280);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(61, 17);
            this.activeCheckBox.TabIndex = 8;
            this.activeCheckBox.Text = "&Active";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.thoughtOutCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.aboutBookTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.booktypeComboBox);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "AddBooksForm";
            this.Text = "Add Book";
            this.Enter += new System.EventHandler(this.saveButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dtx.Windows.Forms.Label label1;
        private Dtx.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.ComboBox booktypeComboBox;
        private Dtx.Windows.Forms.Label label2;
        private Dtx.Windows.Forms.Label label3;
        private Dtx.Windows.Forms.TextBox aboutBookTextBox;
        private Dtx.Windows.Forms.Button closeButton;
        private Dtx.Windows.Forms.Button resetButton;
        private Dtx.Windows.Forms.Button saveButton;
        private Dtx.Windows.Forms.CheckBox thoughtOutCheckBox;
        private Dtx.Windows.Forms.CheckBox activeCheckBox;
    }
}