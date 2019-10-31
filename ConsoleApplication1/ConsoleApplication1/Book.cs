using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Book
    {
        private string Name;
        private Author[] Authors;
        private double Price;
        private int Qty;

        public Book( string name, Author[] authors, double price, int qty =0)
        {
            this.Name = name;
            this.Authors = authors;
            this.Price = price;
            this.Qty = qty;
        }

        //public Book( string name, Author author, double price, int qty = 0)
          //  : this(name, author, price)        
       // {
        //    this.Qty = qty;
      //  }
        public string GetName() { return this.Name; }
        public Author[] GetAuthors() { return this.Authors; }
        public double GetPrice() { return this.Price; }
        public int GetQty() { return this.Qty; }
        public void SetPrice(double price) { this.Price = price; }
        public void SetQty(int qty) { this.Qty = qty;  }



        public override string ToString()
        {
            string[] strAuthors = new string[this.Authors.Length];
            for (int i = 0; i < this.Authors.Length; i++)
            {
                strAuthors[i] = this.Authors[i].ToString();
            }
            return String.Format("Book[name={0},authors={{{1}}},price={2},qty= {3}]",
                this.Name, String.Join(",", strAuthors), this.Price, this.Qty);
        }

        public string GetAuthorNames()
        {
            string[] strAuthorNames = new string[this.Authors.Length];
            for (int i = 0; i < this.Authors.Length; i++)
                strAuthorNames[i] = this.Authors[i].GetName();
                return String.Join(",", strAuthorNames);         
        }



      //  public string GetAuthorName()
     //   {
       //     return this.Name;
      //  }
     //   public string GetAuthorEmail()
      //  {
      //      return this.Authors.GetEmail();
       // }
       // public char GetAuthorGender()
        //{
        //    return this.Authors.GetGender();
        //}
    }
}
