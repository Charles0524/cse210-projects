using System;

class Program
{
    static void Main(string[] args)
    {
        // Store Catalog: 5 GAN Products & 5 MoYu Products with real USD retail pricing
        List<Product> catalog = new List<Product>
        {
            // GAN Speed Cubes
            new Product("GAN 16 Maglev MAX 3x3", "GAN-16M", 84.99, 1),
            new Product("GAN 15 Maglev UV 3x3", "GAN-15UV", 49.95, 1),
            new Product("GAN 12 Maglev UV 3x3", "GAN-12UV", 58.95, 1),
            new Product("GAN 356 ME 3x3 Magnetic", "GAN-356ME", 18.95, 1),
            new Product("GAN 460 M V2 4x4 Magnetic", "GAN-460V2", 54.99, 1),

            // MoYu Speed Cubes
            new Product("MoYu Super WeiLong V2 3x3 Ball-Core UV", "MOYU-SWV2", 72.99, 1),
            new Product("MoYu WeiLong V11 3x3 20-Magnet Ball-Core UV", "MOYU-WLV11", 49.95, 1),
            new Product("MoYu RS3 M V5 3x3 Ball-Core UV + Robot Box", "MOYU-RS3MV5", 24.95, 1),
            new Product("MoYu AoSu V7 4x4 Double-Track Ball-Core UV", "MOYU-AOSUV7", 45.95, 1),
            new Product("MoYu MeiLong 3M V2 3x3 Magnetic", "MOYU-ML3MV2", 6.99, 1)
        };

        Console.WriteLine("=================================================");
        Console.WriteLine("      WELCOME TO CHARLES SPEED CUBE SHOP!        ");
        Console.WriteLine("=================================================\n");

        // Display Store Inventory
        for (int i = 0; i < catalog.Count; i++)
        {
            Product item = catalog[i];
            Console.WriteLine($"{i + 1,2}. [{item.GetProductId()}] {item.GetName()} - ${item.GetPrice():0.00}");
        }

        // Step 1: Customer selects products first
        Order order = new Order();
        bool shopping = true;

        Console.WriteLine("\n--- Step 1: Select Your Speed Cubes ---");
        while (shopping)
        {
            Console.Write("\nEnter product number (1-10) to add to cart (or 0 to checkout): ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 0)
                {
                    if (order.GetSubtotal() == 0)
                    {
                        Console.WriteLine("Your cart is empty! Please select at least one cube.");
                    }
                    else
                    {
                        shopping = false;
                    }
                }
                else if (choice >= 1 && choice <= catalog.Count)
                {
                    Product selectedTemplate = catalog[choice - 1];
                    Console.Write($"Enter quantity for {selectedTemplate.GetName()}: ");
                    if (int.TryParse(Console.ReadLine(), out int qty) && qty > 0)
                    {
                        Product cartItem = new Product(
                            selectedTemplate.GetName(),
                            selectedTemplate.GetProductId(),
                            selectedTemplate.GetPrice(),
                            qty
                        );
                        order.AddProduct(cartItem);
                        Console.WriteLine($"Added {qty}x {cartItem.GetName()} (${cartItem.GetTotalCost():0.00}) to cart.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid quantity. Item not added.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid selection. Choose 1-10 or 0.");
                }
            }
        }

        // Show initial subtotal before address entry
        Console.WriteLine($"\nInitial Product Subtotal (Before Shipping): ${order.GetSubtotal():0.00}");

        // Step 2: Customer enters USA boolean first, then remaining details
        Console.WriteLine("\n--- Step 2: Customer & Shipping Details ---");
        Console.Write("Are you located in the USA? (true/false or yes/no): ");
        string usaInput = Console.ReadLine().Trim().ToLower();
        bool isUsa = (usaInput == "true" || usaInput == "yes" || usaInput == "y");

        Console.Write("Full Name: ");
        string customerName = Console.ReadLine();

        Console.Write("Street Address: ");
        string street = Console.ReadLine();

        Console.Write("City: ");
        string city = Console.ReadLine();

        Console.Write("State / Province: ");
        string stateOrProvince = Console.ReadLine();

        string country = "USA";
        if (!isUsa)
        {
            Console.Write("Country: ");
            country = Console.ReadLine();
        }

        // Create Address and Customer objects and attach to Order
        Address shippingAddress = new Address(isUsa, street, city, stateOrProvince, country);
        Customer customer = new Customer(customerName, shippingAddress);
        order.SetCustomer(customer);

        // Step 3: Recompute total price based on address and display labels
        Console.WriteLine("\n=================================================");
        Console.WriteLine("         FINAL ORDER RECEIPT & LABELS            ");
        Console.WriteLine("=================================================");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Product Subtotal : ${order.GetSubtotal():0.00}");
        Console.WriteLine($"Shipping Fee     : ${order.GetShippingCost():0.00} ({(customer.LivesInUSA() ? "USA Domestic" : "International")})");
        Console.WriteLine($"TOTAL RECOMPUTED : ${order.CalculateTotalPrice():0.00}");
        Console.WriteLine("=================================================");
    }
}