using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductComplaintManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //arrays
                string[] food = new string[] { "", "1.Meat", "2.Poultry", "3.Beef" };
                string[] drinks = new string[] { "", "1.Soda", "2.Water", "3.Juice" };

                //login free account
                string adminUsername = "admin";
                string adminPassword = "admin";

                //for login creation error
                int attempt = 0;

                //first questions
                Console.WriteLine("                        *WELCOME*");
                Console.WriteLine("1.Complaint Form     2.User Login.");

                Console.Write("Enter No: ");
                int form = Convert.ToInt32(Console.ReadLine());
                if (form == 1)
                {
                    Console.WriteLine("     *Welcome to Complaint Form*");
                    Console.WriteLine("Please answer the questions correctly*");

                    //Complainant Datas
                    Console.Write("Enter Name: ");
                    string cName = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int cAge = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Cellphone No#: ");
                    string cNum = Console.ReadLine();
                    Console.Write("Enter Email Address: ");
                    string cEmail = Console.ReadLine();

                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Find the product you have complaints:");
                    Console.WriteLine("Category of Products");
                    Console.WriteLine("");
                    Console.WriteLine("1.Food   2. Drinks");
                    Console.WriteLine("");
                    Console.Write("No# of category you like to see:");
                    int product = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("--Product List--");
                    if (product == 1)
                    {
                        for (int i = 0; i < 4; i++)
                        {

                            Console.WriteLine(food[i]);
                        }

                        Console.WriteLine("Enter the food you have complaints: ");
                        string cProduct = Console.ReadLine();
                        Console.WriteLine("Pls Indicate the Complain issue you have: ");
                        string complains = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine("Finalizing");
                        Console.WriteLine("");
                        Console.WriteLine("Complainants Name: " + cName);
                        Console.WriteLine("Complainants Age: " + cAge);
                        Console.WriteLine("Complainants Number: " + cNum);
                        Console.WriteLine("Complainants Email: " + cEmail);
                        Console.WriteLine("Product Issue: " + cProduct);
                        Console.WriteLine("Product Complains: " + complains);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("*Thank you*\n*We'll send you a feedback regarding your complain as soon as possible*");



                    }
                    else if (product == 2)
                    {
                        for (int i = 0; i < 4; i++)
                        {

                            Console.WriteLine(drinks[i]);
                        }
                        Console.WriteLine("Enter the drinks you have complaints: ");
                        string cProduct = Console.ReadLine();
                        Console.WriteLine("Pls Indicate the Complain issue you have: ");
                        string complains = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine("Finalizing");
                        Console.WriteLine("");
                        Console.WriteLine("Complainants Name: " + cName);
                        Console.WriteLine("Complainants Age: " + cAge);
                        Console.WriteLine("Complainants Number: " + cNum);
                        Console.WriteLine("Complainants Email: " + cEmail);
                        Console.WriteLine("Complainants Product Issue: " + cProduct);
                        Console.WriteLine("Complainants Product Issue: " + complains);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("*Thank you*\n *We'll send you a feedback regarding your complain as soon as possible*");










                    }
                    else
                    {
                        Console.WriteLine("Error Category is Up to 1 and to 2 only");
                        return;
                    }




                }
                else if (form == 2)
                {



                    Console.WriteLine("Do you have an account:(Yes or No)");
                    string firstans = Console.ReadLine().ToLower();
                    if (firstans == "yes")
                    {
                        Console.WriteLine("Proceed");
                        Console.WriteLine("");
                        Console.Write("Enter your Username: ");
                        string userName = Console.ReadLine();
                        Console.Write("Enter your Password: ");
                        string userPass = Console.ReadLine();
                        if (userName == adminUsername && userPass == adminPassword)
                        {

                            Console.WriteLine("Proceed");
                        }
                        else
                        {
                            Console.WriteLine("Username or Password is wrong try again later");
                            return;
                        }


                    }
                    else if (firstans == "no")
                    {

                        Console.Write("Create Username: ");
                        string fUsername = Console.ReadLine();
                        Console.Write("Create Password: ");
                        string fPassword = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Proceed To Sign Up");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("Enter Username:");
                            string eUserame = Console.ReadLine();
                            Console.Write("Enter Password:");
                            string ePassword = Console.ReadLine();
                            if (eUserame == fUsername && fPassword == ePassword)
                            {
                                Console.WriteLine("Proceed");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Error(Up to 3 chance only)");
                                attempt++;




                            }

                        }





                    }

                    else
                    {
                        Console.WriteLine("Only Yes or No Pls try again Later");
                        return;
                    }
                    if (attempt > 2)
                    {
                        Console.WriteLine("Failed to login");
                        return;
                    }
                    else
                    {

                        Console.WriteLine("Login Successfully");
                        Console.WriteLine("");
                    }

                    Console.WriteLine("             *Welcome to Product Complaint System*");
                    Console.WriteLine("                         Good Day");

                    Console.WriteLine("");
                    Console.WriteLine("Product List:");
                    Console.WriteLine("1.Food   2. Drinks");
                    Console.WriteLine("");
                    Console.Write("No# of category you like to see:");
                    int product = Convert.ToInt32(Console.ReadLine());

                    if (product == 1)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine(food[i]);

                        }
                    }
                    else if (product == 2)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine(drinks[i]);
                        }

                    }


                    Console.WriteLine("Finish");





                }

            }
        }
    }
}