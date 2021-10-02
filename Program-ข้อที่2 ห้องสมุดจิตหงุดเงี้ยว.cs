using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Digital Library");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.Write("Select Menu: ");
            int InputMenu = int.Parse(Console.ReadLine());
            Console.Clear();

            if (InputMenu == 2)
            {
                //Register
                Console.WriteLine("Register new Person");
                Console.WriteLine("--------------------------");

                Console.Write("Input name: ");
                string inputName = Console.ReadLine();

                Console.Write("Input password: ");
                string inputPassword = Console.ReadLine();

                string inputID = "";

                Console.Write("Input User Type 1 = Student, 2 = Employee: ");
                int inputUserType = int.Parse(Console.ReadLine());
                if (inputUserType == 1)
                {
                    Console.Write("Student ID: ");
                    inputID = Console.ReadLine();
                    //Student student = new Student(inputName, inputPassword, inputID);
                }
                else if (inputUserType == 2)
                {
                    Console.Write("Employee ID: ");
                    inputID = Console.ReadLine();
                    //Employee employee = new Employee(inputName, inputPassword, inputID);
                }
                Console.Clear();

                //Login
                Console.WriteLine("Welcome to Digital Library");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.Write("Select Menu: ");
                InputMenu = int.Parse(Console.ReadLine());
                Console.Clear();

                if (InputMenu == 1)
                {
                    Console.WriteLine("Login Screen");
                    Console.WriteLine("------------");

                    Console.Write("Input name: ");
                    string inputLoginName = Console.ReadLine();

                    Console.Write("Input Password: ");
                    string inputLoginPassword = Console.ReadLine();


                    if (inputName == inputLoginName && inputPassword == inputLoginPassword && inputUserType == 1)
                    {
                        Console.WriteLine("Student Management");
                        Console.WriteLine("-------------------");
                        Console.Write("Name: " + inputLoginName);
                        Console.WriteLine("Student ID: " + inputID);
                        Console.WriteLine("-------------------");

                        string inputBookID = "";
                        Console.WriteLine("1. Borrow Book");
                        while (inputBookID != "exit")
                        {
                            bool type = false;
                            Console.Write("Input book ID: ");
                            inputBookID = Console.ReadLine();
                            type = true;
                            if (inputBookID == "1" && type == true)
                            {
                                Console.WriteLine("Book ID: 1");
                                Console.WriteLine("Book name:  Now I understand");
                            }
                            if (inputBookID == "2" && type == true)
                            {
                                Console.WriteLine("Book ID: 2");
                                Console.WriteLine("Book name:  Revolutionary Wealth");
                            }
                            if (inputBookID == "3" && type == true)
                            {
                                Console.WriteLine("Book ID: 3");
                                Console.WriteLine("Book name:  Six Degrees");
                            }
                            if (inputBookID == "4" && type == true)
                            {
                                Console.WriteLine("Book ID: 4");
                                Console.WriteLine("Book name:  Les Vacances");
                            }
                            if (inputBookID == "exit")
                            {
                                break;
                            }
                        }
                    }

                    if (inputName == inputLoginName && inputPassword == inputLoginPassword && inputUserType == 2)
                    {
                        Console.WriteLine("Employee Management");
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Name: " + inputLoginName);
                        Console.WriteLine("Employee ID: " + inputID);
                        Console.WriteLine("-------------------");

                        Console.WriteLine("1. Get List Books");
                        /* Console.Write("Input Menu: ");
                         int inputMenu = int.Parse(Console.ReadLine());*/

                        Console.WriteLine("Book List");
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Book ID: 1");
                        Console.WriteLine("Book name:  Now I understand");

                        Console.WriteLine("Book ID: 2");
                        Console.WriteLine("Book name:  Revolutionary Wealth");

                        Console.WriteLine("Book ID: 3");
                        Console.WriteLine("Book name:  Six Degrees");

                        Console.WriteLine("Book ID: 4");
                        Console.WriteLine("Book name:  Les Vacances");
                    }
                }
            }
        }
    }
}

   
           
        
    

