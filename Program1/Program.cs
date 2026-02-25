namespace second_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 0;
            int count = 0;
            int countGame = 0;

            Random rnd = new Random();
            char answer = 'y';
            do
            {
                int counter = 0;
                int number = rnd.Next(1, 100);
                Console.WriteLine("Try guess number?");
                while (true)
                {
                    counter++;
                    int UserNumber = 0;
                    Console.WriteLine("Input namber at from [1;100]");
                    for (int i = 0; i < 3; i++)
                    {
                        if (!int.TryParse(Console.ReadLine(), out UserNumber)
                            || UserNumber > 100 || UserNumber < 1)
                            Console.WriteLine("Input namber at from [1;100]");
                        else break;
                        if (i == 2)
                        {
                            Console.WriteLine("You is stupid");
                            return;
                        }
                    }
                    if (UserNumber > number)
                        Console.WriteLine("Your number is greater");
                    else if (UserNumber < number)
                        Console.WriteLine("Your number is less");
                    else
                    {
                        Console.WriteLine("You are win!!!");

                        if (min == 0 || min > counter) min = counter;
                        max = max < counter ? counter : max;
                        count += counter;
                        countGame++;
                        break;
                    }

                }
                Console.WriteLine("Do you want play game?");
                answer = Convert.ToChar(Console.Read());
            } while (answer == 'y');
            Console.WriteLine($"min = {min} max = {max} ang = {(double)count / countGame}");
        }

    }
}
