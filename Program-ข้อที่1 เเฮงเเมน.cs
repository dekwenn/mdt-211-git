using System;

class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        p.FirstPage();
    }

    void FirstPage()
    {
        Console.WriteLine("Welcome to Hangman Game");
        Console.WriteLine("------------------------");
        Console.WriteLine(" 1. Play game");
        Console.WriteLine(" 2. Exit");
        Console.Write("Please Select Menu : ");
        int keyboardInput = int.Parse(Console.ReadLine());
        if (keyboardInput == 1)
        {
            Console.Clear();
            Program p = new Program();
            p.Ingame();
        }
    }

    void Ingame()
    {
        int incorrectAlphabet = 0;
        string[] randomText = { "Tennis", "Football", "Badminton" };
        Random random = new Random();
        int numberRandom = random.Next(randomText.Length);
        string resultRandom = randomText[numberRandom];

        char[] charArray = resultRandom.ToCharArray();

        char[] charArrayBlank = new char[charArray.Length];
        for (int i = 0; i < charArray.Length; i++)
        {
            charArrayBlank[i] = '_';
        }
        bool win = false;

        while (incorrectAlphabet < 6)
        {
            Console.WriteLine("Play GameHangman");
            Console.WriteLine("------------------------");
            Console.WriteLine("Incorrect Score : {0}", incorrectAlphabet);
            Console.WriteLine(charArrayBlank);
            Console.WriteLine();

            Console.Write("Input letter alphabet: ");
            char keyboardAlphabetInput = char.Parse(Console.ReadLine());
            int check = 0;
            bool inputCorrect = false;
            foreach (char AlphabetInput in charArray)
            {
                if (keyboardAlphabetInput == charArray[check])
                {
                    charArrayBlank[check] = keyboardAlphabetInput;
                    inputCorrect = true;
                }
                check++;
            }
            if (inputCorrect == false)
            {
                incorrectAlphabet++;
            }

            Console.WriteLine("incorrectAlphabet: " + incorrectAlphabet);
            string newResultWord = new string(charArrayBlank);
            Console.Write(newResultWord);
            if (resultRandom == newResultWord)
            {
                win = true;
                Console.Clear();
                break;
            }
            Console.WriteLine();
            Console.Clear();
        }

        if (incorrectAlphabet == 6)
        {
            Console.WriteLine("Play GameHangman");
            Console.WriteLine("------------------------");
            Console.WriteLine("Incorrect Score : {0}", incorrectAlphabet);
            Console.WriteLine(charArrayBlank);
            Console.WriteLine();
            Console.WriteLine("Input letter alphabet: ");
            Console.WriteLine("Game Over");
        }

        if (win == true)
        {
            Console.WriteLine("Play GameHangman");
            Console.WriteLine("------------------------");
            Console.WriteLine("Incorrect Score : {0}", incorrectAlphabet);
            Console.WriteLine(charArrayBlank);
            Console.WriteLine();
            Console.WriteLine("Input letter alphabet: ");
            Console.WriteLine("You win!!");
        }
    }
}
