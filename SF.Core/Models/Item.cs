namespace SF.Core;

public class Item
{
    public string Id { get; set; }
    public string Name { get; set; }
    public Category Category { get; set; }
    public decimal DollarPerKilogram { get; set; }
}