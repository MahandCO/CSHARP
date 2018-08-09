using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class BooksList : Infrastructure.BaseForm
    {
        public Models.Book SelectedBook { get; set; }

        public BooksList()
        {
            InitializeComponent();
            saveButton.Visible = Infrastructure.Utility.AuthenticatedUser.IsAdmin;
            activeCheckBox.Visible = Infrastructure.Utility.AuthenticatedUser.IsAdmin;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Go();
        }
        private void Go()
        {
            Models.DatabaseContext databaseContext = null;
            
            try
            {
                databaseContext =
                    new Models.DatabaseContext();
                
                System.Collections.Generic.List<Models.Book> books = null;
                
                while (bookNameTextbox.Text.Contains("  "))
                {
                    bookNameTextbox.Text =
                        bookNameTextbox.Text.Replace("  ", " ");
                }
                if (bookNameTextbox.Text == string.Empty)
                {
                    books =
                        databaseContext.Books
                        .OrderBy(current => current.Id)
                        .ToList()
                        ;
                }
                else
                {
                    books =
                        databaseContext.Books
                        .Where(current => current.BookName.Contains(bookNameTextbox.Text))
                        .OrderBy(current => current.BookName)
                        .ToList()
                        ;
                }
                
                booksListBox.ValueMember = "Id";
                booksListBox.DisplayMember = "DisplayName";
                booksListBox.DataSource = books;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
            
            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.Book foundedBook =
                    databaseContext.Books
                    .Where(current => current.Id == SelectedBook.Id)
                    
                    .FirstOrDefault();

                if (foundedBook == null)
                {
                    System.Windows.Forms.MessageBox.Show("There is no such a user anymore!");

                    Close();
                }

                foundedBook.IsActive = activeCheckBox.Checked;

                foundedBook.BookName = bookNameTextbox.Text;

                databaseContext.SaveChanges();

                Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

                Close();
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
        
        private void booksListBox_DoubleClick(object sender, EventArgs e)
        {
            Models.Book selectedBook =
                booksListBox.SelectedItem as Models.Book;

            if (selectedBook != null)
            {
                aboutBookTextbox.Text = selectedBook.About;
                thoughtOutCheckBox.Checked = selectedBook.ThoughtOut;
                activeCheckBox.Checked = selectedBook.IsActive;
            }
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            Admin.AddBooksForm editBooksForm = new Admin.AddBooksForm();
            editBooksForm.ShowDialog();
        }

        private void booksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
