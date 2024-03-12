namespace LaboratoriumPO3.Restaurant;

public class Order
{
    public Menu Menu { get; init; }
    private List<OrderItem> _orderItems = new List<OrderItem>();

    public decimal Price
    {
        get
        {
            return 0m;
        }
    }

    public void AddItem(MenuItem item)
    {
        //TODO zmodyfikować metodę, aby uwzględnić dodawanie tych samych itemów
      _orderItems.Add(new OrderItem(){MenuItem = item, Quantity = 1});   
    }

    public void DeleteItem(MenuItem item)
    {
        foreach (var orderitem in _orderItems)
        {
            if (orderitem.MenuItem.Equals(item))
            {
                _orderItems.Remove(orderitem);
            }
        }
    }
}