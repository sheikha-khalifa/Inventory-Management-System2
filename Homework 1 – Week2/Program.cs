namespace Homework_1___Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management System!\r\n" +
                "Please enter your username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();
            if (username == "admin" && password == "adminpass")
            {
                Console.WriteLine("\nAuthentication successful! Welcome, admin!\r\n");

                Console.WriteLine("optionns:\n" +
                    "1. Add a new product\r\n2. Update product quantity\r\n" +
                    "3. Display product list\r\n4. Record sale\r\n5. Generate product report\r\n" +
                    "6. Generate sales report\r\n7. Exit");

                List<string> name = new List<string>();
                List<string> price = new List<string>();
                List<string> quantity = new List<string>();
                List<int> sales = new List<int>();
                List<string> retVal;
                int saleamount = 0;

                Console.WriteLine("\nSelect an operation (1-7):");
                int userchoise = Convert.ToInt32(Console.ReadLine());


                while (userchoise != 7)
                {
                    if (userchoise == 1)
                    {

                        retVal = AddProduct();

                        name.Add(retVal[0]);
                        price.Add(retVal[1]);
                        quantity.Add(retVal[2]);


                    }
                    else if (userchoise == 2)
                    {
                        Console.WriteLine("Enter Product to Update:");
                        string updatedProdect = Console.ReadLine();

                        Console.WriteLine("Enter Update quantity:");
                        string updatedquantity = Console.ReadLine();

                        int upquantity = Convert.ToInt32(quantity[name.IndexOf(updatedProdect)]);
                        upquantity += Convert.ToInt32(updatedquantity);

                        quantity[name.IndexOf(updatedProdect)] = upquantity.ToString();



                    }
                    else if (userchoise == 3) foreach (string item in name) Console.WriteLine(item);
                    else if (userchoise == 4)
                    {
                        Console.WriteLine("Enter product name:");
                        string saleProdect = Console.ReadLine();

                        Console.WriteLine("Enter quantity sold:");
                        string saledquantity = Console.ReadLine();

                        int salequantity = Convert.ToInt32(quantity[name.IndexOf(saleProdect)]);
                        salequantity -= Convert.ToInt32(saledquantity);

                        quantity[name.IndexOf(saleProdect)] = salequantity.ToString();
                        saleamount += Convert.ToInt32(saledquantity);
                        sales.Add(Convert.ToInt32(saledquantity) * Convert.ToInt32(price[name.IndexOf(saleProdect)]));
                        Console.WriteLine("Sale recorded successfully!\n");
                    }
                    else if (userchoise == 5)
                    {
                        for (int i = 0; i < name.Count; i++)
                        {
                            Console.WriteLine($"product name: {name[i]}");
                            Console.WriteLine($"product price: {price[i]}");
                            Console.WriteLine($"product quantity: {quantity[i]}");
                            Console.WriteLine("------------------------------------\n");

                        }

                    }
                    else if (userchoise == 6)
                    {
                        int salenumbers = 0;
                        Console.WriteLine($"total sales: {saleamount}");
                        for (int i = 0; i < sales.Count; i++) salenumbers += sales[i];
                        Console.WriteLine($"Total Revenue: $ {salenumbers}");
                    }
                    else Console.WriteLine("Invalid choice. Please select a valid operation.\r\n");

                    Console.WriteLine("\nSelect an operation (1-7):");
                    userchoise = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\nThank you for using the Inventory Management System, admin!");
            }
            else Console.WriteLine("Authentication unsuccessful!");
        }


        static List<string> AddProduct()
        {
            List<string> getproduct = new List<string>();
            //string[] getproduct = new string[3];
            Console.WriteLine("Enter product name:");
            getproduct.Add(Console.ReadLine());
            Console.WriteLine("Enter product price:");
            getproduct.Add(Console.ReadLine());
            Console.WriteLine("Enter product quantity:");
            getproduct.Add(Console.ReadLine());

            return getproduct;
        }
    }
}