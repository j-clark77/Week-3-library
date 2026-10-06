using Library;

Book book = new Book();

// This is the info for the book class
book.title = "C# for Beginners";
book.author = "Bill Gates";
book.isbn = 123456789;

book.DisplayInfo();

// Add another book 
Book book2 = new Book();
book2.title = "Methods and Classes";
book2.author = "Steve Jobs";
book2.isbn = 987654321;
book2.DisplayInfo();
