using System; 


namespace WpfApp.Models
{
    public class BookOrderModel
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }   //follow DB datatype
        public string Zip { get; set; }
        public string State { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public decimal? Cost { get; set; } 
        public int? Quantity { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; } 



        public BookOrderModel()
        {}

        public BookOrderModel(
            string customername, 
            string address, 
            string city, 
            string zip, 
            string state, 
            string isbn,
            string title,
            decimal cost,
            int quantity, 
            DateTime orderdate,
            string publisher, 
            string author
            )
       
    
        {
            CustomerName = customername;
            Address = address;
            City = city;
            Zip = zip;
            State = state; 
            ISBN = isbn;
            Title= title;
            Cost = cost;
            Quantity = quantity; 
            OrderDate = orderdate;
            Publisher = publisher;
            Author = author;
        }



 
    }
}
