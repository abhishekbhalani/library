using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_WF_DatabaseFirst_Books
{
    public partial class Form1 : Form
    {
        BookWork bk;
        Book book;
        AuthorWork au;
        Author author;
        Publisher publisher;
        PublisherWork pb;
        static int count = 0;
        public Form1()
        {
            InitializeComponent();
            bk = new BookWork();
            book = new Book();
            au = new AuthorWork();
            author = new Author();
            pb = new PublisherWork();
            publisher = new Publisher();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowListBook();
            ShowListAuthor();
            ShowListPublisher();
        }

        //Book
        private void bttnAddBook_Click(object sender, EventArgs e)
        {
            //проверка на информациию
            if (!String.IsNullOrWhiteSpace(txtTitle.Text) && !String.IsNullOrWhiteSpace(txtPrice.Text) && !String.IsNullOrWhiteSpace(txtPages.Text) &&
                !String.IsNullOrWhiteSpace(txtIdpublisher.Text) && !String.IsNullOrWhiteSpace(txtIdAuthor.Text))
            {
                int buf = 0;
                book.Title = txtTitle.Text;

                if (Int32.TryParse(txtPrice.Text, out buf)) book.Price = buf; 
                else MessageBox.Show("Только числовое значение  в поле Price!");

                if (Int32.TryParse(txtPages.Text, out buf)) book.Pages = buf;
                else MessageBox.Show("Только числовое значение  в поле Pages!");

                if (Int32.TryParse(txtIdpublisher.Text, out buf)) book.IdPublisher = buf;
                else MessageBox.Show("Только числовое значение  в поле Idpublisher!");

                if (Int32.TryParse(txtIdAuthor.Text, out buf)) book.IdAuthor = buf;
                else MessageBox.Show("Только числовое значение  в поле IdAuthor!");

                if (Int32.TryParse(txtIdAuthor.Text, out buf) && Int32.TryParse(txtPrice.Text, out buf) && Int32.TryParse(txtPages.Text, out buf) && Int32.TryParse(txtIdpublisher.Text, out buf))
                {
                    bk.Add(book);
                }
                
            }
            else MessageBox.Show("Заполните все поля!");
        }
        private void bttnSaveChng_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                DtGridVwShow.Visible = false;
                count--;
            }
            else
            {
                count++;
                using (Library2Entities db = new Library2Entities())
                {
                    DtGridVwShow.DataSource = null;
                    DtGridVwShow.DataSource = db.Book.ToList();
                    DtGridVwShow.Visible = true;
                }
            }
        
        }
        private void bttnChangeBook_Click(object sender, EventArgs e)
        {
            if (lstBxBook.SelectedIndex != -1)
            {
                
                    //проверка на информациию
                    if (!String.IsNullOrWhiteSpace(txtTitle.Text) && !String.IsNullOrWhiteSpace(txtPrice.Text) && !String.IsNullOrWhiteSpace(txtPages.Text) &&
                    !String.IsNullOrWhiteSpace(txtIdpublisher.Text) && !String.IsNullOrWhiteSpace(txtIdAuthor.Text))

                    {
                        int buf = 0;
                        book.Title = txtTitle.Text;

                        if (Int32.TryParse(txtPrice.Text, out buf)) book.Price = buf;
                        else MessageBox.Show("Только числовое значение  в поле Price!");

                        if (Int32.TryParse(txtPages.Text, out buf)) book.Pages = buf;
                        else MessageBox.Show("Только числовое значение  в поле Pages!");

                        if (Int32.TryParse(txtIdpublisher.Text, out buf)) book.IdPublisher = buf;
                        else MessageBox.Show("Только числовое значение  в поле Idpublisher!");

                        if (Int32.TryParse(txtIdAuthor.Text, out buf)) book.IdAuthor = buf;
                        else MessageBox.Show("Только числовое значение  в поле IdAuthor!");

                        if (Int32.TryParse(txtIdAuthor.Text, out buf) && Int32.TryParse(txtPrice.Text, out buf) && Int32.TryParse(txtPages.Text, out buf) && Int32.TryParse(txtIdpublisher.Text, out buf))
                        {
                            bk.Change(book, Convert.ToInt32(lstBxBook.Items[lstBxBook.SelectedIndex].ToString().Split('.')[0]));
                        }

                    }
                    else MessageBox.Show("Заполните все поля!");
                }
            else MessageBox.Show("Выделите поле в списке книг!");
        }
        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtPrice.Clear();
            txtPages.Clear();
            txtIdpublisher.Clear();
            txtIdAuthor.Clear();
        }
        private void lstBxBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Library2Entities db = new Library2Entities())
            {
                if (db.Book != null)
                {
                    //label1.Text = lstBxBook.Items[lstBxBook.SelectedIndex].ToString().Split('.')[0];
                    var book = db.Book.Find(Convert.ToInt32(lstBxBook.Items[lstBxBook.SelectedIndex].ToString().Split('.')[0]));
                    txtTitle.Text = book.Title;
                    txtPrice.Text = book.Price.ToString();
                    txtPages.Text = book.Pages.ToString();
                    txtIdAuthor.Text = book.IdAuthor.ToString();
                    txtIdpublisher.Text = book.IdPublisher.ToString();
                }
            }
        }
        private void bttnDeleteBook_Click(object sender, EventArgs e)
        {
            if (lstBxBook.SelectedIndex != -1)
            {
                bk.Delete(Convert.ToInt32(lstBxBook.Items[lstBxBook.SelectedIndex].ToString().Split('.')[0]));
            }
            else MessageBox.Show("Выделите поле в списке книг!");
        }

       

        //Author
        private void BttnAuthorAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtFirstNameAuthor.Text) && !String.IsNullOrWhiteSpace(txtLastNameAuthor.Text))
            {
                author.FirstName = txtFirstNameAuthor.Text;
                author.LastName = txtLastNameAuthor.Text;
                au.Add(author);
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void BttnAuthorDel_Click(object sender, EventArgs e)
        {
            if (listBxAuthor.SelectedIndex != -1)
            {
                au.Delete(Convert.ToInt32(listBxAuthor.Items[listBxAuthor.SelectedIndex].ToString().Split('.')[0]));
            }
            else MessageBox.Show("Выделите поле в списке книг!");
        }
        private void BttnAuthorClear_Click(object sender, EventArgs e)
        {
            txtFirstNameAuthor.Clear();
            txtLastNameAuthor.Clear();
        }

        private void BttnAuthorChange_Click(object sender, EventArgs e)
        {
            if (listBxAuthor.SelectedIndex != -1)
            {
                //проверка на информациию
                if (!String.IsNullOrWhiteSpace(txtFirstNameAuthor.Text) && !String.IsNullOrWhiteSpace(txtLastNameAuthor.Text))
                {
                    author.FirstName = txtFirstNameAuthor.Text;
                    author.LastName = txtLastNameAuthor.Text;
                    au.Change(author, Convert.ToInt32(listBxAuthor.Items[listBxAuthor.SelectedIndex].ToString().Split('.')[0]));
                }else MessageBox.Show("Заполните все поля!");
            }else MessageBox.Show("Выделите поле в списке книг!");
        }

       



        //Publisher
        private void btnnPublisherClear_Click(object sender, EventArgs e)
        {
            txtPublisherName.Clear();
            txtAddress.Clear();
        }

        private void btnnPublisherAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtPublisherName.Text) && !String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                publisher.PublisherName = txtPublisherName.Text;
                publisher.Address = txtAddress.Text;
                pb.Add(publisher);
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void btnnPublisherDel_Click(object sender, EventArgs e)
        {
            if (lstBxPublisher.SelectedIndex != -1)
            {
                pb.Delete(Convert.ToInt32(lstBxPublisher.Items[lstBxPublisher.SelectedIndex].ToString().Split('.')[0]));
            }
            else MessageBox.Show("Выделите поле в списке книг!");
        }
        private void btnnPublisherChange_Click(object sender, EventArgs e)
        {
            if (lstBxPublisher.SelectedIndex != -1)
            {
                //проверка на информациию
                if (!String.IsNullOrWhiteSpace(txtPublisherName.Text) && !String.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    publisher.PublisherName = txtPublisherName.Text;
                    publisher.Address = txtAddress.Text;
                    pb.Change(publisher, Convert.ToInt32(lstBxPublisher.Items[lstBxPublisher.SelectedIndex].ToString().Split('.')[0]));
                }
                else MessageBox.Show("Заполните все поля!");
            }
            else MessageBox.Show("Выделите поле в списке книг!");
        }


        //загрузка в lstBx
        private void ShowListBook()
        {
            //при загрузке форы автоматически подгрузка таб. Book in listBox
            using (Library2Entities db = new Library2Entities())
            {
                if (db.Book != null)
                {
                    foreach (var book in db.Book.ToList())
                        lstBxBook.Items.Add($"{book.Id}.\t\"{book.Title}\" \tPages:{book.Pages} \tPrice:{book.Price} \tIdAuthor:{book.IdAuthor}");
                }

            }
        }
        private void ShowListAuthor()
        {
            //при загрузке форы автоматически подгрузка таб. Book in listBox
            using (Library2Entities db = new Library2Entities())
            {
                if (db.Author != null)
                {
                    foreach (var auth in db.Author.ToList())
                        listBxAuthor.Items.Add($"{auth.Id}. \t{auth.FirstName}  {auth.LastName}");
                }

            }
        }
        private void ShowListPublisher()
        {
            //при загрузке форы автоматически подгрузка таб. Book in listBox
            using (Library2Entities db = new Library2Entities())
            {
                if (db.Publisher != null)
                {
                    foreach (var publ in db.Publisher.ToList())
                        lstBxPublisher.Items.Add($"{publ.Id}. \t{publ.PublisherName}  {publ.Address}");
                }

            }
        }

    }
}
