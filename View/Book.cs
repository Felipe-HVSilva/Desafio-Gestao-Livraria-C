namespace Libary.View;

public class Book
{

   public  enum Genders
    {
        Fiction,
        Romance,
        Mystery
    }

    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public Genders Gender { get; set; }
    
    public int Price { get; set; }

    public int Quantity { get; set; }
}
