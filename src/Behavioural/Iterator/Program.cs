using Iterator;

var bookCollection = new BookCollection();

bookCollection.Add(new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger" });
bookCollection.Add(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee" });
bookCollection.Add(new Book { Title = "Pride and Prejudice", Author = "Jane Austen" });

foreach (var book in bookCollection)
{
    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
}