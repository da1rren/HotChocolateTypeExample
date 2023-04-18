namespace HC.CustomerNumberScalar;

public class Book
{
    public CustomerNumber Cis { get; set; }
    
    public string Title { get; set; }

    public Author Author { get; set; }
}

public class Author
{
    public string Name { get; set; }
}
