using System;

namespace HomeworkQuizSimple
{
    class Program
    {
        static char answer = ' ';
        static int score = 0;
        static int i = 0;
        static void isAnswers(bool ans)
        {
            if (ans)
            {
                score += 10;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations. The answer is correct.");
                Console.ReadKey();
            }
            else
            {
                if (answer == 'A' || answer == 'B' || answer == 'C')
                {

                    if (score <= 0)
                    {
                        score = 0;
                    }
                    else
                    {
                        score -= 10;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unfortunately, the answer is wrong.");
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    i -= 1;
                    Console.WriteLine("Wrong choice!");
                    Console.ReadKey();
                }
            }
        }

        static void Questions()
        {
            const sbyte questionsCount = 10;
            string[] questions = new string[questionsCount];
            questions[0] = "What is the size of the int data type ?";
            questions[1] = "What is the size of the char data type in C# ?";
            questions[2] = "What is the size of the decimal data type ?";
            questions[3] = "What is the size of the double data type ?";
            questions[4] = "Which answer used the unary operator ?";
            questions[5] = "How many bytes is the size of the void ?";
            questions[6] = " Which are not access modifiers ?";
            questions[7] = "In what year did C# start operating ?";
            questions[8] = "Which was the first programming language ?";
            questions[9] = "Which of the following is not a programming language on the .Net platform ?";


            string[,] answers = new string[10, 3]
            {
                {" 4 byte"," 8 byte"," 2 byte" },
                {" 4 byte"," 8 byte"," 2 byte" },
                {" 4 byte"," 16 byte"," 1 byte" },
                {" 4 byte"," 8 byte"," 1 byte" },
                {" i--"," z > k"," a + b" },
                {" 4 byte"," 1 byte"," 2 byte" },
                {" References"," Private"," Protected"},
                {" 2010"," 1992"," 2002" },
                {" C++"," Fortran"," Java" },
                {" Visual Basic"," C#"," C++" }
            };

            for (i = 0; i < questionsCount; i++)
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine($"Question {i + 1}");
                Console.WriteLine(questions[i]);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{Convert.ToChar(65 + j)}){answers[i, j]}");
                }
                Console.Write("\nCavabinizi secin: ");

                answer = Convert.ToChar(Console.ReadLine());
                answer = char.ToUpper(answer);

                switch (i)
                {
                    case 0:
                        {
                            if (answer == 'A') isAnswers(true);
                            else isAnswers(false);
                            break;
                        }
                    case 1:
                        {
                            if (answer == 'C') isAnswers(true);
                            else isAnswers(false);
                            break;
                        }
                    case 2:
                        {
                            if (answer == 'B') isAnswers(true);
                            else isAnswers(false);
                            break;
                        }
                    case 3:
                        {
                            if (answer == 'B') isAnswers(true);
                            else isAnswers(false);
                            break;
                        }
                    case 4:
                        {
                            if (answer == 'A') isAnswers(true);
                            else isAnswers(false);
                            break;
                        }
                    case 5:
                        {
                            if (answer == 'B') isAnswers(true);
                            else isAnswers(false);
                            break;
                        }
                    case 6:
                        {
                            if (answer == 'A') isAnswers(true);
                            else isAnswers(false);
                            break;
                        }
                    case 7:
                        {
                            if (answer == 'C') isAnswers(true);
                            else isAnswers(false);
                            break;
                        }
                    case 8:
                        {
                            if (answer == 'B') isAnswers(true);
                            else isAnswers(false);
                            break;
                        }
                    case 9:
                        {
                            if (answer == 'C') isAnswers(true);
                            else isAnswers(false);
                            break;
                        }
                    default:
                        break;
                }

            }
        }
        static void Main(string[] args)
        {
            Console.Title = "QuizSimple";
            Questions();
            Console.Clear();
            Console.WriteLine($"The quiz over !!!\nYour total score: {score}");
            Console.ResetColor();


        }
    }
}
