using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Online Ordering System Simulation ---");

        // Product instances
        Product p1 = new Product("Laptop Pro", "LPT-PRO-001", 1200.00);
        Product p2 = new Product("Mechanical Keyboard", "KEY-MECH-002", 95.50);
        Product p3 = new Product("Wireless Mouse", "MOU-WIRE-003", 30.00);
        Product p4 = new Product("USB-C Hub", "HUB-C-004", 45.00);
        Product p5 = new Product("Monitor 27-inch", "MON-27-005", 299.99);
        Product p6 = new Product("Webcam Full HD", "CAM-HD-006", 60.00);
        Product p7 = new Product("Noise-Cancelling Headphones", "HDP-NC-007", 150.00);
        Product p8 = new Product("External SSD 1TB", "SSD-EXT-008", 110.00);
        Product p9 = new Product("Router Wi-Fi 6", "RTR-WIFI6-009", 80.00);
        Product p10 = new Product("Smart Speaker", "SPK-SMART-010", 75.00);
        Product p11 = new Product("Portable Charger", "CHR-PORT-011", 35.00);
        Product p12 = new Product("E-Reader", "RDR-E-012", 120.00);
        Product p13 = new Product("Fitness Tracker", "TRK-FIT-013", 50.00);
        Product p14 = new Product("Bluetooth Earbuds", "ERB-BT-014", 85.00);
        Product p15 = new Product("Gaming Chair", "CHR-GMG-015", 180.00);

        // Address instances
        Address address1 = new Address("1010 Sunset Blvd", "Los Angeles", "CA", "USA");
        Address address2 = new Address("25 Osu Oxford Street", "Accra", "Greater Accra", "Ghana");
        Address address3 = new Address("Afrancho New Site, Plot 15", "Kumasi", "Ashanti", "Ghana");

        // Customer instances
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Ama Nkrumah", address2);
        Customer customer3 = new Customer("Kwame Mensah", address3);

        Console.WriteLine("\n--- Processing Orders ---");

        // Process order
        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);
        order1.AddProduct(p3);
        order1.AddProduct(p14);
        order1.AddProduct(p15);

        Order order2 = new Order(customer2);
        order2.AddProduct(p4);
        order2.AddProduct(p4);
        order2.AddProduct(p4);
        order2.AddProduct(p4);
        order2.AddProduct(p12);
        order2.AddProduct(p13);
        order2.AddProduct(p3);
        order2.AddProduct(p5);
        order2.AddProduct(p1);
        order2.AddProduct(p6);

        Order order3 = new Order(customer3);
        order3.AddProduct(p7);
        order3.AddProduct(p7);
        order3.AddProduct(p7);
        order3.AddProduct(p8);
        order3.AddProduct(p9);
        order3.AddProduct(p9);
        order3.AddProduct(p9);
        order3.AddProduct(p10);
        order3.AddProduct(p10);
        order3.AddProduct(p11);
        order3.AddProduct(p11);
        order3.AddProduct(p11);

        Console.WriteLine("\n--- Processing Orders Complete ---");
        Console.WriteLine();
        Console.WriteLine();

        address1.GetFullAddressString();
        order1.GetOrderSummary();
        Console.WriteLine();

        address2.GetFullAddressString();
        order2.GetOrderSummary();
        Console.WriteLine();

        address3.GetFullAddressString();
        order3.GetOrderSummary();
        Console.WriteLine();
    }
}