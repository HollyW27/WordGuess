namespace ConsoleWordle;

public class WordleFrontend
{
    public static string userGuessFormat(string guess)
    {
        string formattedGuess = "";
        char[] splitGuess = guess.ToCharArray();
        for (int splitGuessLetter = 0; splitGuessLetter < splitGuess.Length; splitGuessLetter++)
        {
            formattedGuess += "[";
            formattedGuess += splitGuess[splitGuessLetter];
            formattedGuess += "]";
        }
        return formattedGuess;
    }

    public static string incorrectGuessResponseFormat(string correctLetterString)
    {
        string formattedCorrectLetters = "";
        char[] splitCorrecLetters = correctLetterString.ToCharArray();
        for (int correctLetter = 0; correctLetter < splitCorrecLetters.Length; correctLetter++)
        {
            formattedCorrectLetters += "[";
            formattedCorrectLetters += splitCorrecLetters[correctLetter];
            formattedCorrectLetters += "]";
        }
        return formattedCorrectLetters;
    }
    //format the game within the console
    // Give win and losing messages
    //Provide key to guesses
}