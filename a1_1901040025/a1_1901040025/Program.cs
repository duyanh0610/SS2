

namespace a1_1901040025
{
    public class Program
    {

        static void Main(String[] args)
        {
            BookManager b = new BookManager();
            Book book;
            var flag = true;

            while (flag)
            {
                Console.WriteLine("\n" +
                                  "----------------------------------- \n" +
                                  "1.list all books\n" +
                                  "2.add a new book\n" +
                                  "3.edit book\n" +
                                  "4.delete a book\n" +
                                  "5.search books by name\n" +
                                  "6.sort books descending by price\n" +

                                  "0. exit \n" +
                                  "-----------------------------------");

                Console.WriteLine("Your option:");
                var option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    case 0:
                        flag = false;
                        Console.WriteLine("Bye!");
                        break;

                    case 1:
                        b.PrintBooks(b.books);
                        break;

                    case 2:
                        Console.WriteLine("Enter book ID: ");
                        var id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter book name: ");
                        var name = Console.ReadLine();

                        Console.WriteLine("Enter book price: ");
                        var price = Convert.ToDouble(Console.ReadLine());

                        book = new Book(id, name, price);

                        if (b.Add(book) == false)
                        {
                            Console.WriteLine("Duplicated ID!");
                        }
                        else Console.WriteLine("Added successfully.");
                        break;

                    case 3:
                        Console.WriteLine("Enter book ID: ");
                        var edit = Convert.ToInt32(Console.ReadLine());
                        Book editBook = b.GetById(edit);
                        if (editBook != null)
                        {
                            Console.WriteLine("Enter book name:");
                            var newName = Console.ReadLine();

                            Console.WriteLine("Enter book price: ");
                            var newPrice = Convert.ToDouble(Console.ReadLine());

                            editBook.Name = newName;
                            editBook.Price = newPrice;

                            Console.WriteLine("Updated successfully.");
                        }
                        else Console.WriteLine("Invalid ID!");

                        break;

                    case 4:
                        Console.WriteLine("Enter book ID: ");
                        var delete = Convert.ToInt32(Console.ReadLine());
                        Book deleteBook = b.GetById(delete);
                        if (deleteBook != null)
                        {
                            b.Remove(deleteBook);
                            Console.WriteLine("Deleted successfully.");
                        }
                        else Console.WriteLine("Invalid ID!");

                        break;

                    case 5:
                        Console.WriteLine("Enter keyword: ");
                        var keyword = Console.ReadLine();

                        var result = b.SearchByName(keyword);   
                        if (result == null)
                        {
                            Console.WriteLine("(empty)");
                        } else
                        {
                           b.PrintBooks(result);
                        }
                        break;
                 
                    case 6:
                        b.SortDescByPrice();
                        Console.WriteLine("After sorting: ");
                        b.PrintBooks(b.books);
                        break;
                
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }


            }

        }
    }
}

