using ClassLibrary;

ShoppingCart cart = new ShoppingCart();
try
    {
        Laptop laptop = new Laptop("Intel i7", "1TB", "Dell XPS", 1500, 2);
        cart.AddProduct(laptop);

        Smartphone smartphone = new Smartphone("iOS", "128GB", "iPhone 12", 999.99, 3);
        cart.AddProduct(smartphone);

        Lego lego = new Lego(217, "LEGO Technic Monster Jam Dragon", 20, 5);
        cart.AddProduct(lego);

        Console.WriteLine(cart.GetCartDetails());

        Console.WriteLine($"Загальна сума: {cart.CalculateTotalPrice()}");
    }
catch (ArgumentException ex)
    {
        Console.WriteLine($"Помилка: {ex.Message}");
    }