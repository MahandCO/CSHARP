using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication.Admin
{
    public partial class AddBooksForm : Infrastructure.BaseForm
    {
        public AddBooksForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(bookNameTextBox.Text)) ||
                (booktypeComboBox.SelectedItem == null))
            {
                System.Windows.Forms.MessageBox.Show("Book Name and Book Type And Info" +
                    " is requied!");

                if (bookNameTextBox.Text == string.Empty)
                {
                    bookNameTextBox.Focus();
                }
                else
                {
                    booktypeComboBox.Focus();
                }

                return;
            }
            string errorMessages = string.Empty; 
            
            if (errorMessages != string.Empty)
            {
                System.Windows.Forms.MessageBox.Show(errorMessages);

                return;
            }
            
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.Book book =
                    databaseContext.Books
                    .Where(current => string.Compare(current.BookName, bookNameTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (book != null)
                {
                    System.Windows.Forms.MessageBox.Show
                        ("This Book is already exist! Please choose another one...");

                    bookNameTextBox.Focus();

                    return;
                }

                book = new Models.Book();

                book.BookName = bookNameTextBox.Text;
                book.BookType = booktypeComboBox.SelectedText;
                book.About = aboutBookTextBox.Text;
                book.IsActive = activeCheckBox.Checked;
                book.ThoughtOut = thoughtOutCheckBox.Checked;

                databaseContext.Books.Add(book);

                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Book saved!");

                
                resetButton_Click(null, null);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            bookNameTextBox.Text = string.Empty;
            activeCheckBox.Checked = false;
            thoughtOutCheckBox.Checked = false;
            aboutBookTextBox.Text = string.Empty;

            bookNameTextBox.Focus();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBooksForm_Enter(object sender, EventArgs e)
        {

        }
    }
}
