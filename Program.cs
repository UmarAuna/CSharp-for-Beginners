using System;
using MyApplication.Properties;

namespace MyApplication
{

    class MainClass
    {

        public static void Main(string[] args)
        {

            //:: Assigning a variable
            String name = "Umar";
            int age = 24;
            String hobby1 = "running";
            String hobby2 = "playing games";
            Console.WriteLine("My name is " + name);
            Console.WriteLine(name + " is a " + age + " years old");
            Console.WriteLine(name + " loves running and playing games ");
            Console.WriteLine(name + " hobbies are " + hobby1 + " and " + hobby2);


            //:: handling input + Calculator
            Console.Write("Enter your name: ");
            string names = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ages = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);


            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);


            //Mad libs game
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();


            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);


            //:: Arrays
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] planets = new string[3];

            planets[0] = "Mars";
            planets[1] = "Saturn";

            Console.WriteLine(luckyNumbers[1]);


            //:: Methods
            SayHi("Umar", 20);
            SayHi("Auna", 21);
            SayHi("Saidu", 25);

            //:: Return Statement
            int cubeNumber = Cube(5);
            Console.WriteLine(cubeNumber);


            //:: if Statements

            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");

            }




            //:: more if Statements - comparison
            Console.WriteLine(GetMax(20, 10, 40));


            //:: Building a Better Cal cal culator Calculator

            Console.Write("Enter a number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operatore: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(number1 + number2);
            }
            else if (op == "-")
            {
                Console.Write(number1 - number2);
            }
            else if (op == "*")
            {
                Console.Write(number1 * number2);
            }
            else if (op == "/")
            {
                Console.Write(number1 / number2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }


            //:: Switch Statement
            Console.WriteLine(GetDay(4));


            //:: While Loops and Do While Loops

            int index = 6;
            while (index <= 5)
            {
                Console.WriteLine("I am Sorry");
                index++;
            }

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);


            //:: Building a guesing game
            string secretWord = "mars";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outofGuesses = false;

            //While Loop

            while (guess != secretWord && !outofGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess:");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outofGuesses = true;
                }


            }
            if (outofGuesses)
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }



            // Do While Loop

            do
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess:");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outofGuesses = true;
                }

            } while (guess != secretWord && !outofGuesses);

            if (outofGuesses)
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }


            //:: For Loops

            int[] luckyNumber = { 4, 8, 15, 16, 23, 42 };
            for (int i = 0; i < luckyNumber.Length; i++)
            {
                Console.WriteLine(luckyNumber[i]);
            }


            //:: Building an Exponent Method
            Console.WriteLine(GetPow(4, 3));

            //:: 2d Arrays
            int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] myArray = new int[2, 3];

            Console.WriteLine(numbers[1, 0]);




            //:: Exception Handling

            try
            {
                Console.Write("Enter a number: ");
                int nums1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                int nums2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(nums1 / nums2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }





            //: Classes & Objects

            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;


            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book2.author);




            //:: Constructors

            Book book3 = new Book("Harry Potter", "JK Rowling", 400);
            Book book4 = new Book("Lord of the Rings", "Tolkein", 700);

            book2.title = "The hobbit";

            Console.WriteLine(book3.title);


            //:: Object Methods

            Student student1 = new Student("Umar", "Computer Science", 5.0);
            Student student2 = new Student("Abubakar", "Biology", 3.0);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());




            //:: Getters and Setters

            Movie movie1 = new Movie("The Avengers", "Joss Whedon", "Meat");
            Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(movie1.Rating);




            //:: Static Class Attributes

            Song song1 = new Song("Lonely", "Akon", 500);
            Console.WriteLine(Song.songCount);
            Song song2 = new Song("Am not Afraid", "Eminem", 200);
            Console.WriteLine(Song.songCount);





            //:: Static Methods & Classes

            Console.WriteLine(Math.Sqrt(144));
            UsefulTools.sayHi("Umar");





            //:: Inheritance
            Chef chef = new Chef();
            chef.MakeSpecialDish();


            ItallianChef itallianhef = new ItallianChef();
            itallianhef.MakeSpecialDish();




        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;

            }
            return dayName;
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            /*
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            */

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }


        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello World " + name + " your age " + age);
        }



        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}
