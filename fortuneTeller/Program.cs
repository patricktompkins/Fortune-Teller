using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            string firstName = "blank";
            string lastName = "blank";
            int age = 0;
            int birthMonth = 1;
            string favoriteColor = "R";
            int siblingsNumber = 0;
            string helpMenu = "F";


            //Outputs
            int yearsToRetirement = 0;
            string vacationCity = "Germany";
            string transportation = "0";
            decimal moneyAmount = 0.00m;



            Console.WriteLine("Help Menu");
            Console.WriteLine("Select H for Help Menu or select any other key to continue with your FORTUNE!!!. ");

            helpMenu = Console.ReadLine();
            helpMenu = helpMenu.ToUpper();

       

            if (helpMenu == "H")
            {
                //This is the help menu. 
                Console.WriteLine("This application will provide your FUTURE FORTUNE!!!.");
                Console.WriteLine();
                Console.WriteLine("The user will provide personal information when prompted by the application.");
                Console.WriteLine();
                Console.WriteLine("Example: enter your first/last name");
                Console.WriteLine();
                Console.WriteLine("Example: enter your age");
                Console.WriteLine();
                Console.WriteLine("Example: enter your birth month");
                Console.WriteLine();
                Console.WriteLine("Example: enter your favorite color");
                Console.WriteLine();
                Console.WriteLine("Example: enter number of your siblings.");
                Console.WriteLine();
                Console.WriteLine("Please select enter to continue with your fortune.");
                Console.ReadLine();
            
            }

           
            
                //This is for the Fortune
                //This is where requested user information is enter.

                Console.WriteLine("Please enter your first name. ");
                firstName = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter your last name. ");
                lastName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Please enter your age. ");
                age = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter the 1-12 for your birth month. ");
                birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter your favorite color from the the following colors: Red, Orange, Yellow, Green, Blue, Indigo, Violet. ");
                favoriteColor = Console.ReadLine();
                favoriteColor = favoriteColor.ToUpper();
            Console.WriteLine();
            Console.WriteLine("Please enter your number of siblings. ");
                siblingsNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //This section is regarding fortune

            yearsToRetirement = 65 - age;



                //Calculate Vacation Location

                if (siblingsNumber > 3 || siblingsNumber < 0)
                {
                    vacationCity = "London";
                }


                else if (siblingsNumber == 1)
                {

                    vacationCity = "Paris";
                }

                else if (siblingsNumber == 2)
                {
                    vacationCity = "Los Angeles";
                }

                else
                {
                    vacationCity = "Berlin";
                }

                if (birthMonth >= 1 && birthMonth <= 4)
                {

                    moneyAmount = 100000.00m;
                }

                else if (birthMonth >= 5 && birthMonth <= 8)
                {
                    moneyAmount = 200000.00m;
                }

                else if (birthMonth >= 9 && birthMonth <= 12)
                {
                    moneyAmount = 300000.00m;
                }

                else
                {
                    moneyAmount = 0.00m;
                }




                //Calculate Mode of Transportation

                switch (favoriteColor)
                {
                    case "RED":
                        transportation = "Charger";
                        break;

                    case "ORANGE":
                        transportation = "Mustang";
                        break;

                    case "YELLOW":
                        transportation = "Honda Civic";
                        break;

                    case "GREEN":
                        transportation = "Ford Focus";
                        break;

                    case "BLUE":
                        transportation = " Ponitac GTO";
                        break;

                    case "INDIGO":
                        transportation = " Chevy Nova";
                        break;

                    case "VIOLET":
                        transportation = " Ford F-150";
                        break;

                    default:
                        transportation = "Two Wheel Bicycle";
                        break;
                } 


                // This is the Display of the Fortune

                if (1 == (yearsToRetirement % 2))
                {
                    Console.WriteLine(firstName + " " + lastName + " will retire not " + yearsToRetirement + " years with $" + 
                        moneyAmount + " in the bank, a vacation home in " + vacationCity + " and a " + transportation + ". ");
                }


                else
                {
                    Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsToRetirement + " years with $" +
                        moneyAmount + " in the bank, a vacation home in " + vacationCity + " and a " + transportation + ". ");

                }

                Console.WriteLine();
                Console.WriteLine("Select X button and select the ENTER button to exit the application");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Nobody likes a quitter...");



            












        }
    }
}