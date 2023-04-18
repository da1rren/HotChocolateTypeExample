namespace HC.CustomerNumberScalar;

public class Query
{
    public Book GetBook() =>
        new Book
        {
            Title = "C# in depth.",
            Cis = new CustomerNumber
            {
                Id = "0123456789"
            },
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
    
    public Book GetBookByCis(CustomerNumber customerNumber) =>
        new Book
        {
            Title = "C# in depth.",
            Cis = new CustomerNumber
            {
                Id = customerNumber.Id
            },
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
}
