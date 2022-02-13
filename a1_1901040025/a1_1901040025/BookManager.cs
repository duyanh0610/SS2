using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1_1901040025
{
    public class BookManager
    {
        private List<Book> Books;
        public List<Book> books {
            get { return Books; } 
            set { Books = value; } 
        }

       


        public BookManager()
        {
            books = new List<Book>();
        }


        public void PrintBooks(List<Book> books)
           
        {
            if ( books.Count == 0 )  Console.WriteLine("(empty)");
            
            else
            {
                var heading = string.Format("{0,-5} {1,-45} {2,-10}", "ID","Name","Price");
                Console.WriteLine(heading);
                foreach (Book item in books)
                {
                    var print = item.ToString();
                    Console.WriteLine(print);
                }
            }

            
        }
        public bool Add(Book book)
        {
            var result= true;

            if (books.Count > 0)
            {
                foreach (Book item in Books.ToList())
                {
                    if (book.Id == item.Id)
                    {
                        result = false;
                        return result;
                        
                    } else result = true;
                  
                }
                if (result) { Books.Add(book); }
            }

            if (books.Count == 0)
            {
                Books.Add(book);
                return true;
            }
                return result;
        }

        public Book GetById(int id)
        {
            foreach(Book item in Books)
            {
                if ( id == item.Id)
                {
                    return item;
                }
            }
            return null;
        }

        public void Remove(Book book)
        {
            Books.Remove(book);
        }

        public void SortDescByPrice()
        {
            Book tp = new Book();
            for ( int i = 0; i < Books.Count-1; i++)
            {
                for( int j =i+1 ; j < Books.Count; j++)
                {
                    if (Books[i].Price < Books[j].Price)
                    {
                        tp = Books[i];
                        Books[i] = Books[j];
                        Books[j] = tp;
                    }
                }
            }
        }

        public List<Book> SearchByName(String keyword)
        {
            List <Book> result = new List<Book>();
            foreach(Book item in Books)
            {
                if (item.Name.ToLower().Contains(keyword.ToLower()))
                {
                    result.Add(item);
                    
                } 
            }
            return result;
        }
    }
}
