using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyQuestions();
        }
        static void TwentyQuestions()//declaring a new method
        {
            
            Random rand = new Random();//used to declare random integers
            int question = 0;//numbers the questions
            int correct = 0;//numbers how may questions were correct
            while(question < 20)
            {
                question = ++question;//adds one to question
                int operation = rand.Next(1, 5);//determines which math operation to use
                if (operation == 1)//performs addition if operation is 1
                {
                    double a = rand.Next(1, 21);//random generates A
                    double b = rand.Next(1, 21);//random generates b
                    Console.WriteLine($"{question}: What is {a} + {b}?");//asks the user what a + b is
                    double usersinput = Convert.ToDouble(Console.ReadLine());//converts users input to an double and stores it
                    double c = a + b;//finds the answer to a + b
                    if (usersinput == c)//if usersinput= the correct answer this will happen
                    {
                        correct = ++correct;//add 1 to correct
                        Console.WriteLine("That is correct!");
                    }
                    else//otherwise user answer is incorrect
                    {
                        Console.WriteLine($"The correct answer was {c}");
                        continue;
                    }
                }
                else if (operation == 2)//performs multiplication if operation is 2
                {
                    double a = rand.Next(1, 21);//makes random double a
                    double b = rand.Next(1, 21);//makes random double b
                    Console.WriteLine($"{question}: What is {a} * {b}?");//asks the user what a * b is
                    double c = a * b;//finds the actual answer
                    double usersinput = Convert.ToDouble(Console.ReadLine());//converts users input to an double and stores it
                    if (usersinput == c)// happens if userinput is correct
                    {
                        correct = ++correct;//adds one to correct
                        Console.WriteLine("That is correct!");
                    }
                    else//happens if usersinput is correct
                    {
                        Console.WriteLine($"The correct answer was {c}");
                        continue;
                    }
                }
                else if (operation == 3)
                {
                    double a = rand.Next(1, 21);
                    double b = rand.Next(1, 21);
                    Console.WriteLine($"{question}: What is {a} - {b}");
                    double usersinput = Convert.ToDouble(Console.ReadLine());
                    double c = a - b;
                    if ( usersinput == c)
                    {
                        correct = ++correct;
                        Console.WriteLine("That is correct!");
                    }
                    else
                    {
                        Console.WriteLine($"The correct answer was {c}");
                        continue;
                    }
                   
                }
                else//happens if operation is 4
                {
                    double a = rand.Next(1, 21);//creates random a
                    double b = rand.Next(1, 21);//creates random b
                    Console.WriteLine($"{question}: What is {a}/{b}?");//asks the user what a/b is
                    double usersinput = Convert.ToDouble(Console.ReadLine());//converts to double and stores usersinput
                    double c = a / b;//finds actual answer
                    if (usersinput == c)//happens if user gets answer correct
                    {
                        correct = ++correct;//adds one to correct
                        Console.WriteLine("That is correct!");
                    }
                    else//happens if user gets answer incorrect
                    {
                        Console.WriteLine($"The correct answer was {c}");//tells user correct number
                        continue;
                    }
                   
                }
                
            }
            Console.WriteLine($"You got {correct} correct!");//tells user how many the got correct

        }

    }
}
