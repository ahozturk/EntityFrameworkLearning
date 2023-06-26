using CreatingQueries;
using Microsoft.EntityFrameworkCore;
//*******************

Console.WriteLine("Running...");

List<Book> books = new List<Book>();
#region Sample Datas
books.Add(new Book { Id = Guid.NewGuid(), Name = "Harry Potter and the Sorcerer's Stone", Page = 336, Author = "J.K. Rowling" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "To Kill a Mockingbird", Page = 324, Author = "Harper Lee" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "1984", Page = 328, Author = "George Orwell" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "The Great Gatsby", Page = 180, Author = "F. Scott Fitzgerald" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "Pride and Prejudice", Page = 432, Author = "Jane Austen" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "The Catcher in the Rye", Page = 224, Author = "J.D. Salinger" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "To the Lighthouse", Page = 209, Author = "Virginia Woolf" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "Moby-Dick", Page = 720, Author = "Herman Melville" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "The Hobbit", Page = 304, Author = "J.R.R. Tolkien" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "The Chronicles of Narnia", Page = 767, Author = "C.S. Lewis" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "Brave New World", Page = 288, Author = "Aldous Huxley" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "The Lord of the Rings", Page = 1178, Author = "J.R.R. Tolkien" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "Jane Eyre", Page = 624, Author = "Charlotte Brontë" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "Animal Farm", Page = 112, Author = "George Orwell" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "The Odyssey", Page = 475, Author = "Homer" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "Wuthering Heights", Page = 416, Author = "Emily Brontë" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "The Alchemist", Page = 208, Author = "Paulo Coelho" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "Frankenstein", Page = 280, Author = "Mary Shelley" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "Gone with the Wind", Page = 960, Author = "Margaret Mitchell" });
books.Add(new Book { Id = Guid.NewGuid(), Name = "The Kite Runner", Page = 363, Author = "Khaled Hosseini" });
#endregion

var a = books.FirstOrDefault(b => b.Author == "Ahmet Hakan Öztürk");

//Single
//SingleOrDefault
//First
//FirstOrDefault

Console.WriteLine();

public class Book
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Page { get; set; }
    public string Author { get; set; }
}