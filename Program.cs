//Angelica Alonzo

using System;

namespace Angelica_Alonzo_PA1
{
    class Program
    {
        static int score = 0; 
        static int problems = 0;
        static void Main(string[] args)
        {
            int ch;
            int NumOne= 0 ;
            int NumTwo = 0;
            int Answer = 0;
           
            do
            {
                menu(); 

            ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Answer = ReadExpression(out NumOne, out NumTwo);
                    break; 

                case 2: 
                    CheckAnswer(NumOne, NumTwo, Answer); 
                    break;

                case 3:
                    DisplayScore();
                    break;

            }
            
            } while (ch!= 4);

        }

    public static void menu()
    {
        Console.WriteLine("Welcome");
        Console.WriteLine("1. Enter expression");
        Console.WriteLine("2. Check the Answer");
        Console.WriteLine("3. Display Score");
        Console.WriteLine("4. Exit");

    }

       public static int ReadExpression(out int NumOne, out int NumTwo)
        {

            Console.WriteLine("Enter your expression");
            string Expression = Console.ReadLine();
            string[] ExpressionComp = Expression.Split('*', '=');
            NumOne = Convert.ToInt32(ExpressionComp[0]);
            NumTwo = Convert.ToInt32(ExpressionComp[1]);
            int Answer = Convert.ToInt32(ExpressionComp[2]);

            Console.WriteLine("You entered {0} * {1} = {2}", NumOne, NumTwo, Answer);
            problems++;

            return Answer;



        }

        public static void CheckAnswer(int NumOne, int NumTwo, int Answer)
        {
            int result= NumOne * NumTwo; 
          
            if( problems == 0 ){

                Console.WriteLine("You must enter an expression first");
                
            }

            else if( Answer == result)
            {
           
             Console.WriteLine("The correct answer was {0}" ,result);

                Console.WriteLine("You got the answer correct!");
                score ++; 
            }
            else {
                Console.WriteLine("Sorry, that answer was incorrect.");
                Console.WriteLine("The correct answer was {0}" ,result);
                  
            }
           
        }

        public static void DisplayScore()
        {
            Console.WriteLine("You got {0} answers correct out of {1} ", score, problems);
            
        }

        }
    }

