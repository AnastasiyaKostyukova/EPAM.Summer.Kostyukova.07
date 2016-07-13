using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
  // the class is not yet implemented
  public class Book : IEquatable<Book>, IComparable<Book>
  {

    public string Author { get; set; }
    public string Title { get; set; }
    public int Pages { get; set; }
    public decimal Price { get; set; }
    public int YearOfPublication { get; set; }

    public Book(
      string author, string title, int pages, decimal price, int yearOfPublication)
    {
      Author = author;
      Title = title;
      Pages = pages;
      Price = price;
      YearOfPublication = yearOfPublication;      
    }


    public int CompareTo(Book other)
    {
      throw new NotImplementedException();
    }

    public bool Equals(Book other)
    {
      throw new NotImplementedException();
    }
  }
}
