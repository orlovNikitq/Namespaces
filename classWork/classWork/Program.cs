using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //num 1-2
            /*
            char[,] board = new char[3, 3];
            int currentPlayer = 1;
            int x, y;
            int flag = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }

            do
            {
                Console.Clear();
                Console.WriteLine("Игрок 1: X и Игрок 2: O");
                Console.WriteLine();
                if (currentPlayer % 2 == 0)
                {
                    Console.WriteLine("Ход Игрока 2");
                }
                else
                {
                    Console.WriteLine("Ход Игрока 1");
                }
                Console.WriteLine("\n");
                PrintBoard(board);

                Console.Write("Введите координату x: ");
                x = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Введите координату y: ");
                y = int.Parse(Console.ReadLine()) - 1;

                if (x < 0 || x > 2 || y < 0 || y > 2 || board[x, y] == 'X' || board[x, y] == 'O')
                {
                    Console.WriteLine("Недопустимый ход. Пожалуйста, попробуйте снова(Enter).");
                    Console.ReadLine();
                }
                else
                {
                    if (currentPlayer % 2 == 0)
                    {
                        board[x, y] = 'O';
                        currentPlayer++;
                    }
                    else
                    {
                        board[x, y] = 'X';
                        currentPlayer++;
                    }
                }
                flag = CheckWin(board);
            }
            while (flag != 1 && flag != -1);

            Console.Clear();
            PrintBoard(board);
            if (flag == 1)
            {
                Console.WriteLine("Игрок {0} победил!", (currentPlayer % 2) + 1);
            }
            else
            {
                Console.WriteLine("Ничья!");
            }
            Console.ReadLine();
            */
            //num3-4
            /*
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Текст в азбуку Морзе");
            Console.WriteLine("2. Азбука Морзе в текст");
            int choice = Convert.ToInt32(Console.ReadLine());
            Dictionary<char, string> dict = new Dictionary<char, string>()
            {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."}, {'F', "..-."}, {'G', "--."}, {'H', "...."},
            {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."},
            {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"}, {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
            {'Y', "-.--"}, {'Z', "--.."}
            };

            if (choice == 1)
            {
                Console.WriteLine("Введите текст для перевода в азбуку Морзе:");
                string text = Console.ReadLine();
                text = text.ToUpper(); 

                for (int i = 0; i < text.Length; i++)
                {
                    char currentChar = text[i];

                    if (dict.ContainsKey(currentChar))
                    {
                        string morseCode = dict[currentChar];
                        Console.Write(morseCode + " ");
                    }
                    else if (currentChar == ' ')
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            else if(choice == 2)
            {
                Console.WriteLine("Введите азбуку Морзе для перевода в текст(через пробел):");
                string morseCode = Console.ReadLine();
                string[] morseWords = morseCode.Split(' ');

                foreach (string morseWord in morseWords)
                {
                    if (morseWord == "") // Пропускаем пустые слова (пробелы)
                    {
                        Console.Write(" ");
                        continue;
                    }

                    var matchingChar = dict.FirstOrDefault(kv => kv.Value == morseWord);
                    if (!matchingChar.Equals(default(KeyValuePair<char, string>))) 
                    {
                        Console.Write(matchingChar.Key); 
                    }
                }
                Console.WriteLine();
            }
            */
        }
        private static void PrintBoard(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + board[i, j] + " ");
                    if (j < 2)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (i < 2)
                {
                    Console.WriteLine("-----------");
                }
            }
        }
        private static int CheckWin(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return 1; 
                }
            }

    
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] != ' ' && board[0, j] == board[1, j] && board[1, j] == board[2, j])
                {
                    return 1; 
                }
            }
            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return 1; 
            }
            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return 1; 
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        return 0; 
                    }
                }
            }

            return -1; 
        }
    }

}