class Order
{
    private List<Product>_products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {_customer = customer;}

    public void AddProduct(Product product)
    {_products.Add(product);}

    public double GetOrderTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {total += product.GetTotalCost();}

        double shipping = _customer.LivesINUSA() ? 5.0 : 35.0;
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label: \n";
        foreach (Product product in _products)
        {label += $"Product Name: {product.GetName()}, Product ID: {product.GetID()}\n";}

        return label;
    }

    public string GetShippingLabel()
    {return $"Shipping Label: \n{_customer.GetName()} \n{_customer.GetAddress()}";}

}