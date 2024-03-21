namespace Libary.Communication.Request;

public class RequestUpdateBookJson
{
    public string Author { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public int Price { get; set; }

    public int Quantity { get; set; }
}
