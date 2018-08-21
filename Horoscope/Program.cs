using System;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOROSCOPE"); //Title
            Console.Write("Enter DOB: "); //Allows user to enter date of birth.
            DateTime birth = DateTime.Parse(Console.ReadLine()); //Reads what the user entered as a date.

            Console.Write("You were born on a " + birth.DayOfWeek + "."); //Prints the day of the week the user was born.
            

            DateTime now = DateTime.Now; //New date and time variable declared and set to the current date and time.
           
            int nextBirth = now.Year; //new integer varibale declared and set to the current year.

            if (birth.Month <= now.Month || birth.Day <= now.Day) //If the user's birthday was before today, 
                nextBirth++;                                      //their next birthday will be next year.

            DateTime nextBirthDate = DateTime.Parse(birth.Month.ToString() + "/" //A new date and time created as the user's next birthday.
               + birth.Day.ToString() + "/" + nextBirth.ToString());

            Console.Write(" Your upcoming birthday is on a " + nextBirthDate.DayOfWeek + "."); //Prints the day of the week the user's next birthday
            Console.ReadLine();                                                                //is on.

            Console.WriteLine(); //Creates a line of spaces after the user's next birthday and before printing zodiac and fortune.


            //These statements below makes the corresponding zodiac and fortune print to the console
            //that matches the user's birthday.
            if (birth.Month == 3 && birth.Day >= 21 || birth.Month == 4 && birth.Day <= 19)
            {
                Console.WriteLine("Zodiac: Aries");
                Console.WriteLine();
                Console.WriteLine("Fortune: In 5 years you will be rich!");
                Console.ReadLine();
            }
            else if (birth.Month == 4 && birth.Day >= 20 || birth.Month == 5 && birth.Day <= 20)
            {
                Console.WriteLine("Zodiac: Taurus");
                Console.WriteLine();
                Console.WriteLine("Fortune: In 10 years you will be rich!");
                Console.ReadLine();

            }
            else if (birth.Month == 5 && birth.Day >= 21 || birth.Month == 6 && birth.Day <= 20)
            {
                Console.WriteLine("Zodiac: Gemini");
                Console.WriteLine();
                Console.WriteLine("Fortune: Tomorrow morning, a spider will be on your face towel!");
                Console.ReadLine();
            }
            else if (birth.Month == 6 && birth.Day >= 21 || birth.Month == 7 && birth.Day <= 22)
            {
                Console.WriteLine("Zodiac: Cancer");
                Console.WriteLine();
                Console.WriteLine("Fortune: In 3 years, you will be #1 at your profession!");
                Console.ReadLine();
            }
            else if (birth.Month == 7 && birth.Day >= 23 || birth.Month == 8 && birth.Day <= 22)
            {
                Console.WriteLine("Zodiac: Leo");
                Console.WriteLine();
                Console.WriteLine("Fortune: In 3 days, you will be recieving something you've always wanted!");
                Console.ReadLine();

            }
            else if (birth.Month == 8 && birth.Day >= 23 || birth.Month == 9 && birth.Day <= 22)
            {
                Console.WriteLine("Zodiac: Virgo");
                Console.WriteLine();
                Console.WriteLine("Fortune: You're having a baby in 2 years!");
                Console.ReadLine();
            }
            else if (birth.Month == 9 && birth.Day >= 23 || birth.Month == 10 && birth.Day <= 22)
            {
                Console.WriteLine("Zodiac: Libra");
                Console.WriteLine();
                Console.WriteLine("Fortune: In 15 years you will be rich!");
                Console.ReadLine();
            }
            else if (birth.Month == 10 && birth.Day >= 23 || birth.Month == 11 && birth.Day <= 21)
            {
                Console.WriteLine("Zodiac: Scorpio");
                Console.WriteLine();
                Console.WriteLine("Fortune: Your favorite food will be provided to you for dinner tomorrow.");
                Console.ReadLine();
            }
            else if (birth.Month == 11 && birth.Day >= 22 || birth.Month == 12 && birth.Day <= 21)
            {
                Console.WriteLine("Zodiac: Sagittarius");
                Console.WriteLine();
                Console.WriteLine("Fortune: You will marry your high school sweetheart!");
                Console.ReadLine();
            }
            else if (birth.Month == 12 && birth.Day >= 22 || birth.Month == 1 && birth.Day <= 19)
            {
                Console.WriteLine("Zodiac: Capricorn");
                Console.WriteLine();
                Console.WriteLine("Fortune: In 3 months, your favorite snack is releasing a new flavor!");
                Console.ReadLine();
            }
            else if (birth.Month == 1 && birth.Day >= 20 || birth.Month == 2 && birth.Day <= 18)
            {
                Console.WriteLine("Zodiac: Aquarius");
                Console.WriteLine();
                Console.WriteLine("Fortune: In 6 months, you will recieve a pay raise!");
                Console.ReadLine();
            }
            else if (birth.Month == 2 && birth.Day >= 19 || birth.Month == 3 && birth.Day <= 20)
            {
                Console.WriteLine("Zodiac: Pisces");
                Console.WriteLine();
                Console.WriteLine("Fortune: In 2 months, you will receive a job promotion!");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Sorry, we can't assign a zodiac and fortune to that.");
                Console.ReadLine();
            }    
        }
    }
}
