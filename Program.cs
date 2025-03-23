using System;

class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }

    public Product(string name, int quantity, float price)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Товар: {Name}, Количество: {Quantity}, Стоимость: {Price}");
    }
}

class Program
{
    static void Main()
    {
        Product product = new Product("Молоко", 10, 50.5f);
        product.DisplayInfo();
    }
}
