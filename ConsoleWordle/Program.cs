using ConsoleWordle;

string answer = WordCheck.createWord().ToUpper();
//Get guess
string guess = answer;
string guessFormatted = WordleFrontend.userGuessFormat(answer);
Console.WriteLine(guessFormatted);
if (!WordCheck.validWord(guess))
{
    Console.WriteLine("That is not a word. Enter a 5 letter word.");
}
else if (answer == guess)
{
    //WordleFrontend.win();
    Console.WriteLine("Correct!");
}
else
{
    WordleFrontend.incorrectGuessResponseFormat(WordCheck.correctLetters(guess, answer));
}