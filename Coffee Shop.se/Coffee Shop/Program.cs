using System.Drawing;

namespace Coffee_Shop
{
     class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the  Muna Coffee Shop!\r\n");
            Console.WriteLine( "Menu:" );
            string number1 = (" Americano ");
            string number2 = ("Latte");
            string number3 = ("Cappuccino");
            Console.WriteLine("1. Americano - $2.50 ");
            Console.WriteLine("2. Latte - $3.00");
            Console.WriteLine("3. Cappuccino - $3.50");
            int number;
            Console.Write("Select a coffee (1-3): ");
            number = Convert.ToInt32(Console.ReadLine());
            //if (number == 1)
            //{
            //    Console.WriteLine("Americano  - $2.50 ");
            //}
            //else if (number == 2)
            //{
            //    Console.WriteLine("Latte - $3.00");
            //}
            //else
            //{
            //    Console.WriteLine("Cappuccino - $3.50");
            //}

            //    size virbal 
                Console.WriteLine("Customizations:\r");
            string size1 = " Small";
            string size2 = "Medium";
            string size3 = "Large";
            Console.WriteLine("1.Small\r");
            Console.WriteLine("2.Medium");
            Console.WriteLine("3.Large\r");
            int size;
            Console.Write("\n Select a size (1-3): ");
            size = Convert.ToInt32(Console.ReadLine());

            //if (size==1)
            //{
            //    Console.WriteLine("Small");
            //}
            //else if (size==2)
            //{
            //    Console.WriteLine("Medium");
            //}
            //else
            //{
            //    Console.WriteLine("Large");
            //}

            string sugar1= "yes";
            string sugar2= "no";
            string sugar;
            
            
            Console.Write("Do you want sugar? (yes/no):");
            sugar = Console.ReadLine();
            //if(sugar=="yes")
            //{
            //    Console.WriteLine("with suger");

            //}
            //else
            //{
            //    Console.WriteLine("no suger ");
            //}
            string milke1 = "yes";
            string milk2 = "no";
            string milk;
        
            Console.Write("Do you want milk? (yes/no): ");
            milk = Console.ReadLine();
            //if (milk == "yes")
            //{
            //    Console.WriteLine("with milk");



            //}
            //else
            //{
            //    Console.Write("no milk ");
            //}
            if (number == 1)
            {
                Console.WriteLine("Americano  - $2.50 ");

            }
            else if (number == 2)
            {
                Console.WriteLine("Latte - $3.00");
            }
            else
            {
                Console.WriteLine("Cappuccino - $3.50");
            }
            if (size == 1)
            {
                Console.WriteLine("Small");
            }
            else if (size == 2)
            {
                Console.WriteLine("Medium");
            }
            else
            {
                Console.WriteLine("Large");
            }
            if (sugar == "yes")
            {
                Console.WriteLine("with suger");
                Console.Read();

            }
            else
            {
                Console.WriteLine("no suger ");
            }
            if (milk == "yes")
            {
                Console.WriteLine("with milk");



            }
            else
            {
                Console.Write("no milk ");
                  
            }
            Console.WriteLine("Your Order Summary:" + number +size + sugar + milk);
            Console.WriteLine("Total Cost:" );
            Console.WriteLine("Thank you for ordering!");


            //string customer;
            //Console.WriteLine("Do you want sugar? (yes/no):");
            //customer = Convert.ToInt32(Console.ReadLine());






        }
    }
}