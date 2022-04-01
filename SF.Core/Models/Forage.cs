namespace SF.Core;

public class Forage
{
    
    public string Id { get; set; } // System generated field
    public DateOnly Date { get; set; }
    public string ForagerId { get; set; }
    public string ItemId { get; set; }
    public decimal Kilograms { get; set; }
    
    public Forager Forager { get; set; }
    public Item Item { get; set; }
}