using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1_1901040025
{
    public class Book
    {
        private int id;
        private string name;
        private double price;

        public int Id {
            get 
                { return id;}
            set 
                { id = value;}
        }
        public string Name { 
            get
                { return name;}
            set 
                { name = value;}
                
        }

        public double Price {
            get
                { return price; }
            set 
                { price = value;  } 
        }
            
        public Book() { }

        public Book(int id, string name, double price)
        {
        this.id = id;
        this.name = name;
        this.price = price;
        }

        public override string ToString()
        {
        //string heading = string.Format("{0,-5}  {1,-45}   {2,-10}  ", "Id","Name","Price");
        var detail = string.Format("{0,5} {1,-45} {2,10:N2}", id, name, price);

        return  detail;
               
        }
    }
}
