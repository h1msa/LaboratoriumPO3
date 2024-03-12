namespace LaboratoriumPO3.Restaurant;

public class Menu
{
    public List<MenuItem> Items { get; set; }
    public List<Order> Orders { get; set; }
    public DateOnly Published { get; init; }
}