using DesignPatternIterview.DataLayer.Model;
using DesignPatternIterview.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternIterview
{
    class Program
    {
        static void Main(string[] args)
        {
            // new NotificationCreator().CreateNotification("SMS").NotifyUser(); 
            var book = new Book { Name = "C#" };

            using (var context = new BookStoreDbContext())
            {
                try
                {
                    context.Books.Add(book);
                    context.SaveChanges();
                    var bookPrice = new BookPrice { BookId = book.Id, Price = "100" };
                    context.BookPrices.Add(bookPrice);
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    var e = ex;
                }
                
            }

        }
    }
}
