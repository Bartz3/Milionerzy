using Milionerzy;
using System.Text;

Game game = new Game();

Console.WriteLine("Nowa gra");
Console.WriteLine("Ustawienia");
Console.WriteLine("Rekordy");
Console.WriteLine("Wyjście");

game.isGameActive = true;
game.questions = game.readQuestions("easy.txt"); // List of questions in the game

while (game.isGameActive)
{
    Console.WriteLine("Witaj w grze Milionerzy!\n Podaj swój nick: ");
    game.playerName=Console.ReadLine();
    Console.WriteLine("Sześć "+game.playerName);

    if (Console.ReadKey().Key == ConsoleKey.X) game.isGameActive = false;
    Console.WriteLine("Pytanie numer xd");
    Console.WriteLine(game.questions[0].question);
    Console.WriteLine(game.questions[0].answerA);
    Console.WriteLine(game.questions[0].answerB);
    Console.WriteLine(game.questions[0].answerC);
    Console.WriteLine(game.questions[0].answerD);
    
    
}

Console.ReadKey();
