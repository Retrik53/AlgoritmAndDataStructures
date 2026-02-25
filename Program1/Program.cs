namespace second_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация переменных для статистики игры
            int min = 0;           // Минимальное количество попыток для победы
            int max = 0;           // Максимальное количество попыток для победы
            int count = 0;         // Общее количество попыток во всех играх
            int countGame = 0;     // Количество сыгранных игр

            // Создание генератора случайных чисел
            Random rnd = new Random();
            char answer = 'y';     // Переменная для ответа на вопрос о повторной игре

            // Основной игровой цикл - выполняется, пока игрок хочет играть
            do
            {
                int counter = 0;   // Счетчик попыток в текущей игре

                // Генерация случайного числа от 1 до 99
                int number = rnd.Next(1, 100);

                Console.WriteLine("Try guess number?");

                // Бесконечный цикл угадывания числа
                while (true)
                {
                    counter++;      // Увеличиваем счетчик попыток
                    int UserNumber = 0;   // Переменная для числа, введенного пользователем

                    Console.WriteLine("Input namber at from [1;100]");

                    // Цикл для проверки корректности ввода (максимум 3 попытки)
                    for (int i = 0; i < 3; i++)
                    {
                        // Проверка, является ли ввод числом и находится ли оно в диапазоне [1;100]
                        if (!int.TryParse(Console.ReadLine(), out UserNumber)
                            || UserNumber > 100 || UserNumber < 1)
                            Console.WriteLine("Input namber at from [1;100]");
                        else break;   // Если ввод корректен, выходим из цикла проверки

                        // Если после 3 попыток ввод некорректен
                        if (i == 2)
                        {
                            Console.WriteLine("You is stupid");
                            return;    // Завершаем программу
                        }
                    }

                    // Сравнение введенного числа с загаданным
                    if (UserNumber > number)
                        Console.WriteLine("Your number is greater");   // Число больше загаданного
                    else if (UserNumber < number)
                        Console.WriteLine("Your number is less");      // Число меньше загаданного
                    else
                    {
                        // Игрок угадал число
                        Console.WriteLine("You are win!!!");

                        // Обновление статистики
                        // Для минимального количества попыток
                        if (min == 0 || min > counter) min = counter;

                        // Для максимального количества попыток
                        max = max < counter ? counter : max;

                        // Обновление общего количества попыток и количества игр
                        count += counter;
                        countGame++;

                        break;   // Выход из цикла угадывания
                    }
                }

                // Запрос на повторную игру
                Console.WriteLine("Do you want play game?");
                answer = Convert.ToChar(Console.Read());   // Чтение ответа (ожидается 'y' или что-то другое)

            } while (answer == 'y');   // Продолжаем, если ответ 'y'

            // Вывод итоговой статистики игр
            // ang - среднее количество попыток (count / countGame)
            Console.WriteLine($"min = {min} max = {max} ang = {(double)count / countGame}");
        }
    }
}