using System;
using System.Diagnostics;

namespace BikeManagement
{
    class Program
    {
        static public void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            IQueue bikeManagement = new BikeCollection();
            Bike aBike = new Bike();
            IBST customerManagement = new CustomerCollection();
            IQueue maintanence = new RepairQueue();
            
            // Create and initiate 50 bikes
            Bike bike1 = new Bike("1");
            Bike bike2 = new Bike("2");
            Bike bike3 = new Bike("3");
            Bike bike4 = new Bike("4");
            Bike bike5 = new Bike("5");
            Bike bike6 = new Bike("6");
            Bike bike7 = new Bike("7");
            Bike bike8 = new Bike("8");
            Bike bike9 = new Bike("9");
            Bike bike10 = new Bike("10");
            Bike bike11 = new Bike("11");
            Bike bike12 = new Bike("12");
            Bike bike13 = new Bike("13");
            Bike bike14 = new Bike("14");
            Bike bike15 = new Bike("15");
            Bike bike16 = new Bike("16");
            Bike bike17 = new Bike("17");
            Bike bike18 = new Bike("18");
            Bike bike19 = new Bike("19");
            Bike bike20 = new Bike("20");
            Bike bike21 = new Bike("21");
            Bike bike22 = new Bike("22");
            Bike bike23 = new Bike("23");
            Bike bike24 = new Bike("24");
            Bike bike25 = new Bike("25");
            Bike bike26 = new Bike("26");
            Bike bike27 = new Bike("27");
            Bike bike28 = new Bike("28");
            Bike bike29 = new Bike("29");
            Bike bike30 = new Bike("30");
            Bike bike31 = new Bike("31");
            Bike bike32 = new Bike("32");
            Bike bike33 = new Bike("33");
            Bike bike34 = new Bike("34");
            Bike bike35 = new Bike("35");
            Bike bike36 = new Bike("36");
            Bike bike37 = new Bike("37");
            Bike bike38 = new Bike("38");
            Bike bike39 = new Bike("39");
            Bike bike40 = new Bike("40");
            Bike bike41 = new Bike("41");
            Bike bike42 = new Bike("42");
            Bike bike43 = new Bike("43");
            Bike bike44 = new Bike("44");
            Bike bike45 = new Bike("45");
            Bike bike46 = new Bike("46");
            Bike bike47 = new Bike("47");
            Bike bike48 = new Bike("48");
            Bike bike49 = new Bike("49");
            Bike bike50 = new Bike("50");

            //stopwatch.Start();

            // Use method Enqueue to add 50 bikes into the queue
            bikeManagement.Enqueue(bike1);
            bikeManagement.Enqueue(bike2);
            bikeManagement.Enqueue(bike3);
            bikeManagement.Enqueue(bike4);
            bikeManagement.Enqueue(bike5);
            bikeManagement.Enqueue(bike6);
            bikeManagement.Enqueue(bike7);
            bikeManagement.Enqueue(bike8);
            bikeManagement.Enqueue(bike9);
            bikeManagement.Enqueue(bike10);
            bikeManagement.Enqueue(bike11);
            bikeManagement.Enqueue(bike12);
            bikeManagement.Enqueue(bike13);
            bikeManagement.Enqueue(bike14);
            bikeManagement.Enqueue(bike15);
            bikeManagement.Enqueue(bike16);
            bikeManagement.Enqueue(bike17);
            bikeManagement.Enqueue(bike18);
            bikeManagement.Enqueue(bike19);
            bikeManagement.Enqueue(bike20);
            bikeManagement.Enqueue(bike21);
            bikeManagement.Enqueue(bike22);
            bikeManagement.Enqueue(bike23);
            bikeManagement.Enqueue(bike24);
            bikeManagement.Enqueue(bike25);
            bikeManagement.Enqueue(bike26);
            bikeManagement.Enqueue(bike27);
            bikeManagement.Enqueue(bike28);
            bikeManagement.Enqueue(bike29);
            bikeManagement.Enqueue(bike30);
            bikeManagement.Enqueue(bike31);
            bikeManagement.Enqueue(bike32);
            bikeManagement.Enqueue(bike33);
            bikeManagement.Enqueue(bike34);
            bikeManagement.Enqueue(bike35);
            bikeManagement.Enqueue(bike36);
            bikeManagement.Enqueue(bike37);
            bikeManagement.Enqueue(bike38);
            bikeManagement.Enqueue(bike39);
            bikeManagement.Enqueue(bike40);
            bikeManagement.Enqueue(bike41);
            bikeManagement.Enqueue(bike42);
            bikeManagement.Enqueue(bike43);
            bikeManagement.Enqueue(bike44);
            bikeManagement.Enqueue(bike45);
            bikeManagement.Enqueue(bike46);
            bikeManagement.Enqueue(bike47);
            bikeManagement.Enqueue(bike48);
            bikeManagement.Enqueue(bike49);
            bikeManagement.Enqueue(bike50);

            //stopwatch.Stop();
            //Console.WriteLine("time : " + stopwatch.ElapsedMilliseconds + "ms");

            // Preset several customers in the system
            Customer customer1 = new Customer("Park", "Yena", 0426237908);
            Customer customer2 = new Customer("Park", "Mary", 0423323968);
            Customer customer3 = new Customer("Rowe", "John", 0455555555);

            customerManagement.Insert(customer1);
            customerManagement.Insert(customer2);
            customerManagement.Insert(customer3);

            string fName;
            string lName;
            int phone;
            string option;

            // Options
            const string RENT = "111";
            const string RETURN = "222";
            const string ADD_CUSTOMER = "333";
            const string REMOVE_CUSTOMER = "444";
            const string STATUS = "555";
            const string NEED_REPAIR = "777";
            const string REPAIR = "888";
            const string QUIT = "999";


            // Excute the program
            do
            {
                Console.WriteLine("\n=== Bike Management ===");
                Console.WriteLine("\nRent: 111\nReturn: 222\nAdd customer: 333\nRemove customer: 444\nDisplay status: 555\nAdd to repair list: 777\nRepair: 888\nQuit:999");
                Console.Write("\nPlease enter an option >> ");
                option = Console.ReadLine();
                if (option == RENT)
                {
                    Rent();
                }
                else if (option == RETURN)
                {
                    Return();
                }
                else if (option == ADD_CUSTOMER)
                {
                    AddCustomer();
                }
                else if (option == REMOVE_CUSTOMER)
                {
                    RemoveCustomer();

                }
                else if (option == STATUS)
                {
                    DisplayStatus();

                }
                else if (option == NEED_REPAIR)
                {
                    AddToRepairList();
                }
                else if (option == REPAIR)
                {
                    Repair();
                }
            }
            while (option != QUIT);


            void Rent()
            {
                while (bikeManagement.CurrentQty > 0)
                {
                    aBike = bikeManagement.Dequeue();
                    bikeManagement.CurrentQty -= 1;

                    // Check it's in the repair list
                    if (maintanence.Search(aBike) == null)
                    {
                        Customer aCustomer = AddCustomer();
                       
                        aCustomer.addBike(aBike);
                        customerManagement.Delete(aCustomer);
                        customerManagement.Insert(aCustomer);
                        Console.WriteLine("\nRent success.");
                        break;
                    }
                }

                if (bikeManagement.CurrentQty == 0)
                {
                    Console.WriteLine("\nSorry, there is no available bike to rent at the moment.");
                }
            }

            void Return()
            {
                Console.WriteLine("\n=== Please provide the details to return ===\n");
                Console.Write("Enter your first name >> ");
                fName = Console.ReadLine();
                Console.Write("Enter your last name >> ");
                lName = Console.ReadLine();
                Console.Write("Enter your mobile number >> ");
                phone = Convert.ToInt32(Console.ReadLine());

                Customer aCustomer = new Customer(lName, fName, phone);

                if (customerManagement.Search(aCustomer) != null)
                {
                    if (aCustomer.GetBorrowingBike == null)
                    {
                        Console.WriteLine("\nNo bike with given details.");
                    }
                    else
                    {
                        aBike = aCustomer.GetBorrowingBike;
                        aCustomer.deleteBike();
                        customerManagement.Delete(aCustomer);
                        customerManagement.Insert(aCustomer);
                        bikeManagement.Enqueue(aBike);
                        bikeManagement.CurrentQty += 1;
                        Console.WriteLine("\nReturned.");
                    }
                }
                // Wrong details
                else
                {
                    Console.WriteLine("\nCan't find any bike with given details.");
                }

            }

            // Add customer to the customer management binary search tree
            Customer AddCustomer()
            {
                Console.WriteLine("\n=== Details for the customer list ===\n");
                Console.Write("Enter your first name >> ");
                fName = Console.ReadLine();
                Console.Write("Enter your last name >> ");
                lName = Console.ReadLine();
                Console.Write("Enter your mobile number >> ");
                phone = Convert.ToInt32(Console.ReadLine());

                Customer aCustomer = new Customer(lName, fName, phone);

                // Check the customer already exists and add new customer
                if (customerManagement.Search(aCustomer) != null)
                {
                    aCustomer = customerManagement.Search(aCustomer);
                    Console.WriteLine("\nAlready exists in the customer list.");
                }
                else
                {
                    customerManagement.Insert(aCustomer);
                    Console.WriteLine("\nSaved to the customer list.");
                }
                return aCustomer;
            }

            void RemoveCustomer()
            {
                Console.WriteLine("\n=== Details to remove ===\n");
                Console.Write("Enter your first name >> ");
                fName = Console.ReadLine();
                Console.Write("Enter your last name >> ");
                lName = Console.ReadLine();
                Console.Write("Enter your mobile number >> ");
                phone = Convert.ToInt32(Console.ReadLine());

                // Check whether the customer exists or not and delete the details
                if (customerManagement.Search(new Customer(lName, fName, phone)) != null)
                {
                    customerManagement.Delete(new Customer(lName, fName, phone));
                    Console.WriteLine("\nDeleted.");
                }
                else
                    Console.WriteLine("\nNot found.");
            }

            void DisplayStatus()
            {
                Console.WriteLine("\n=== Current Status ===\n");
                Console.WriteLine("   Name    Mobile    Rent");
                customerManagement.InOrderTraverse();
            }

            void AddToRepairList()
            {
                string broken;

                Console.Write("\nEnter the bike ID you want to add to the repair list >> ");
                broken = Console.ReadLine();
                Bike aBike = new Bike(broken);

                // Check if it's already in the repair list
                if (maintanence.Search(aBike) != null)
                {
                    Console.WriteLine("\nAlready exists in the repair list.");
                }
                // Add to the repair list if it's not currently being used
                else if (bikeManagement.Search(aBike) != null)
                {
                    maintanence.Enqueue(aBike);
                    Console.WriteLine("\nAdded to the repair list.");
                }
                else
                {
                    Console.WriteLine("\nThis bike is currently being used.");
                }
            }

            // Repair and bring it back to the bike collection
            void Repair()
            {
                string repair = "y";
                Console.WriteLine("\n=== Repair list ===\n");
                maintanence.Print();
                Console.Write("\nIf you want to repair a bike in the repair list, please enter 'y' >> ");
                if (repair == Console.ReadLine())
                {
                    aBike = maintanence.Dequeue();
                    bikeManagement.Enqueue(aBike);
                }
            }
        }
    }
}
