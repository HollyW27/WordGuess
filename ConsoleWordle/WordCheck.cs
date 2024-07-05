using System.Text;
using NetSpell.SpellChecker;
using NetSpell.SpellChecker.Dictionary;

namespace ConsoleWordle;

public class WordCheck
{
    private HashSet<string> dictionary;

    public WordCheck()
    {
        for (int wordinDictionary = 0; wordinDictionary < 12920; wordinDictionary++)
        {
            //Create a dictionary that puts all of the words from the ValidWords file into a variable and change all word checks to check it
            StreamReader dictonaryReader = new StreamReader(@"C:\Users\holly\RiderProjects\ConsoleWordle\ListOfWords.txt");
            string word = dictonaryReader.ReadLine();
            dictionary.Add(word);
        }
    }
    
    //Creates a random word
    public string createWord()   
    {
        StreamReader randomWord = new StreamReader(@"C:\Users\holly\RiderProjects\ConsoleWordle\ListOfWords.txt");
        Random randomPositionChoice = new Random();
        int numberIndex = randomPositionChoice.Next(1,487);
        int currentIndex = 0;
        string answer = "";
        while (numberIndex > currentIndex)
        {
            answer = randomWord.ReadLine();
            currentIndex++;
        }
        return answer;
    }
    
    //Checks if a word is valid
    public bool validWord(string guess)
    {
        StreamReader validWordChecker = new StreamReader(@"C:\Users\holly\RiderProjects\ConsoleWordle\ValidWords.txt");
        string currentWordCheck = validWordChecker.ReadLine();
        if (guess.Length != 5)
        {
            throw new Exception("Word needs to be of length 5.");
        }

        while (currentWordCheck != "")
        {
            currentWordCheck = validWordChecker.ReadLine();
            Console.WriteLine(currentWordCheck);
            if (guess == currentWordCheck)
            {
                return true;
            }
        }
        return false;
    }
    
    //Checks if guess is the same as the created word and returns the correct letters
    public static string correctLetters(string guess, string answer)
    {
        StringBuilder letterOrder = new StringBuilder("");
            for (int i = 0; i < guess.Length; i++)
            {
                //Right position and letter
                if(answer[i] == guess[i])
                {
                    letterOrder.Insert(i, "X");
                }
                //Right Letter wrong position
                else if (answer.Contains(guess[i]))
                {
                    letterOrder.Insert(i, "O");
                }
                else
                {
                    letterOrder.Insert(i, " ");
                }
            }

            return letterOrder.ToString();
    }
}