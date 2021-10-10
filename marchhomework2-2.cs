using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
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

                Console.Write("Input User Type 1 = Student, 2 = Teacher: ");
                int inputUserType = int.Parse(Console.ReadLine());
                if (inputUserType == 1)
                {
                    Console.Write("Student ID: ");
                    inputID = Console.ReadLine();
                    //Student student = new Student(inputName, inputPassword, inputID);
                }
                else if (inputUserType == 2)
                {
                    Console.Write("Teacher ID: ");
                    inputID = Console.ReadLine();
                    //Employee employee = new Employee(inputName, inputPassword, inputID);
                }
                Console.Clear();

                //Login
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

                        if (inputName == inputLoginName && inputPassword == inputLoginPassword && inputUserType == 2)
                        {
                            Console.WriteLine("Teacher Management");
                            Console.WriteLine("-------------------");
                            Console.WriteLine("Name: " + inputLoginName);
                            Console.WriteLine("Teacher ID: " + inputID);
                            Console.WriteLine("-------------------");
                        }
                    }
                }
            }
        }

    }
}


   
           
        
    

