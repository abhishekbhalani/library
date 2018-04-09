using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_WF_DatabaseFirst_Books
{
    public abstract class aLibrary
    {
        public  abstract void  Add(object Obj);
        public abstract void Delete(int index);
        public abstract void Change(object book, int index);
    }
    public class BookWork : aLibrary
    {
        public override void Add(object book)
        {
            using (Library2Entities db = new Library2Entities())
            {
                db.Book.Add((Book)book);
                db.SaveChanges();
            }
        }

        public override void Change(object book, int index)
        {
            using (Library2Entities db = new Library2Entities())
            {
                Book b = (Book)book;
                var bk = db.Book.Find((index+1));
                bk.Title = b.Title;
                bk.IdAuthor = b.IdAuthor;
                bk.IdPublisher = b.IdPublisher;
                bk.Pages = b.Pages;
                bk.Price = b.Price;

                db.SaveChanges();
            }
        }

        public override void Delete(int index)
        {
            using (Library2Entities db = new Library2Entities())
            {
                var book = db.Book.Find((index));
                db.Book.Remove(book);
                db.SaveChanges();
            }
        }
    }
    public class AuthorWork : aLibrary
    {
        public override void Add(object author)
        {
            using (Library2Entities db = new Library2Entities())
            {
                db.Author.Add((Author)author);
                db.SaveChanges();
            }
        }

        public override void Change(object author, int index)
        {
            using (Library2Entities db = new Library2Entities())
            {
                Author a = (Author)author;
                var bk = db.Author.Find((index));
                bk.FirstName = a.FirstName;
                bk.LastName = a.LastName;
                db.SaveChanges();
            }
        }

        public override void Delete(int index)
        {
            using (Library2Entities db = new Library2Entities())
            {
                var author = db.Author.Find((index));
                try
                {
                    db.Author.Remove(author);
                    db.SaveChanges();
                }
                catch (Exception) { MessageBox.Show("Невозможно удалить!"); }

            }
        }
    }
    public class PublisherWork : aLibrary
    {
        public override void Add(object publisher)
        {
            using (Library2Entities db = new Library2Entities())
            {
                db.Publisher.Add((Publisher)publisher);
                db.SaveChanges();
            }
        }

        public override void Change(object publisher, int index)
        {
            using (Library2Entities db = new Library2Entities())
            {
                Publisher p = (Publisher)publisher;
                var bk = db.Publisher.Find((index));
                bk.PublisherName = p.PublisherName;
                bk.Address = p.Address;
                db.SaveChanges();
            }
        }

        public override void Delete(int index)
        {
            using (Library2Entities db = new Library2Entities())
            {
                var publisher = db.Publisher.Find((index));
                try
                {
                    db.Publisher.Remove(publisher);
                    db.SaveChanges();
                }
                catch (Exception) { MessageBox.Show("Невозможно удалить!"); }

            }
        }
    }
}
