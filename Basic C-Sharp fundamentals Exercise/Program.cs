using System;

namespace Basic_C_Sharp_fundamentals_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            //Exercise7();
            //Exercise8();
            //Exercise9();
        }


        /*
        Write a program and ask the user to enter a number.
        The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console.
        Otherwise, display "Invalid". 
        (This logic is used a lot in applications where values entered into input boxes need to be validated.)
        */
        static void Exercise1(){
            Console.WriteLine("Enter a number between");
            string inputNum = Console.ReadLine();
            int convertNum = Convert.ToInt32(inputNum);

            Console.WriteLine("Enter a number");
            string inputNum2 = Console.ReadLine();
            int convertNum2 = Convert.ToInt32(inputNum2);

            if (convertNum > convertNum2)
            {
                Console.WriteLine("The greater nums is: " + convertNum);
            }
            else
            {
                Console.WriteLine("The greater number is: " + convertNum2);
            }
        }


        /*
         2- Write a program which takes two numbers from the console and displays the maximum of the two.
         */

        static void Exercise2() {
            Console.WriteLine("Enter a number between");
            string inputNum = Console.ReadLine();
            int convertNum = Convert.ToInt32(inputNum);

            Console.WriteLine("Enter a number");
            string inputNum2 = Console.ReadLine();
            int convertNum2 = Convert.ToInt32(inputNum2);

            if (convertNum > convertNum2)
            {
                Console.WriteLine("The greater nums is: " + convertNum);
            }
            else
            {
                Console.WriteLine("The greater number is: " + convertNum2);
            }
        }

        /*Write a program and ask the user to enter the width and height of an image. 
         * Then tell if the image is landscape or portrait.*/
        static void Exercise3() {
            Console.WriteLine("Enter width of an image ");
            string inputWidth = Console.ReadLine();
            int width = Convert.ToInt32(inputWidth);


            Console.WriteLine("Enter height of an image ");
            string inputHeight = Console.ReadLine();
            int height = Convert.ToInt32(inputHeight);

            if (width > height)
            {
                Console.WriteLine("The image is a landscape ");
            }
            else
            {
                Console.WriteLine("The image is a portrait");
            }
        }

        /*
         Your job is to write a program for a speed camera. 
        For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
        Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. 
        If the user enters a value less than the speed limit, program should display Ok on the console. 
        If the value is above the speed limit, the program should calculate the number of demerit points. 
        For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
        If the number of demerit points is above 12, the program should display License Suspended.
         */
        static void Exercise4() {
            Console.WriteLine("Enter the speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the car speed");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed > speedLimit)
            {
                Ticket(carSpeed, speedLimit);
            }
            else
            {
                Console.WriteLine("OK");
            }
        }
        public static void Ticket(int speed, int limit)
        {

            int points = 0;
            const int demerit = 5;

            int difference = speed - limit;
            points = (difference / demerit);

            Console.WriteLine("You have " + points.ToString() + " demerit");
        }

        /*
         Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        Display the count on the console.
         */
        static void Exercise5() {
            int count = 100;
            for (int i = 0; i < count; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " , ");
                }
            }
        }
        /*
         Write a program and continuously ask the user to enter a number or "ok" to exit. 
        Calculate the sum of all the previously entered numbers and display it on the console.
         */
        static void Exercise6()
        {
            var sum = 0;

            while (true)
            {
                Console.WriteLine("Enter your number or ok to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;

                }
                sum += Convert.ToInt32(input);

                continue;
            }
            Console.Write("The sum is :" + sum);
        }
        /*
          Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
        For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
         */
        static void Exercise7()
        {
            Console.WriteLine("Enter your number ");

            int num = Convert.ToInt32(Console.ReadLine());

            var fact = 1;

            while (num != 1)
            {
                fact = fact * num;
                num = num - 1;
            }

            Console.WriteLine(fact);
        }
        /*
         Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
        If the user guesses the number, display “You won"; otherwise, display “You lost". 
        (To make sure the program is behaving correctly, you can display the secret number on the console first.)
         */
        static void Exercise8()
        {
            var rand = new Random();
            const int guesses = 4;

            var random = rand.Next(1, 10);



            for (int i = 0; i < guesses; i++)
            {
                Console.WriteLine("Enter guess, number of guess: " + i);
                var userGuess = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(random);
                if (random == userGuess)
                {
                    Console.WriteLine("You won!");
                    Console.WriteLine("the random guess is :" + random);
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine("You Lose");
                }
                else
                    Console.WriteLine("Keep guessing");
                continue;

            }
        }
        /*
         Write a program and ask the user to enter a series of numbers separated by comma. 
         Find the maximum of the numbers and display it on the console. 
        For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
         */
        static void Exercise9()
        {
            Console.WriteLine("Enter a series of number seperated by commas ,");
            var input = Console.ReadLine();

            string[] numbers = input.Split(",");

            int max = Convert.ToInt32(numbers[0]);

            // var nums = Console.ReadLine().Split(' , ');
            foreach (string str in numbers)
            {
                var tempNum = Convert.ToInt32(str);

                if (max < tempNum)
                {
                    max = tempNum;
                }

            }

            Console.WriteLine(max);
        }


       


    }
}
