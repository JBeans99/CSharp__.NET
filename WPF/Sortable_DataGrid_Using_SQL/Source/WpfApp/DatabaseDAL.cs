using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApp.Models;    

namespace WpfApp
{
   public class DatabaseDAL
    {
       private static BookstoreEntities ctx = new BookstoreEntities(); 

       public static IList<BookOrderModel> GetOrders()
      
       {
           var query = from c in ctx.Customers
                       join o in ctx.Orders on c.CustomerID equals o.CustomerID
                       join oi in ctx.OrderItems on o.OrderItemID equals oi.OrderItemID
                       join b in ctx.Books on oi.ISBN equals b.ISBN
                       join p in ctx.Publishers on b.PubID equals p.PubID
                       join ba in ctx.BookAuthors on b.ISBN equals ba.ISBN
                       join au in ctx.Authors on ba.AuthorID equals au.AuthorID  
                       select new BookOrderModel()
                           {
                               CustomerName = c.FirstName + " " + c.LastName,
                               Address = c.Address,
                               City = c.City,
                               State = c.State,
                               Zip = c.Zip,
                               ISBN = b.ISBN,
                               Title = b.Title,
                               Cost = b.Cost,
                               Quantity = o.Quantity,  
                               OrderDate = o.OrderDate,
                               Publisher = p.Name,
                               Author = au.FName + " " + au.LName,
                           };

           return query.ToList();
       } 

    }
}
