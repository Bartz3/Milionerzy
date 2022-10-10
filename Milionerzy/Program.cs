using Milionerzy;
using System.Text;


Console.WriteLine("Nowa gra");
Console.WriteLine("Ustawienia");
Console.WriteLine("Rekordy");
Console.WriteLine("Wyjście");

Console.WriteLine("Wybierz poziom trudnośći");
Console.Write("1. Łatwy \t\t");
Console.Write("2. Średni\t\t");
Console.Write("3. Trudny\n");

string diffLvl = Console.ReadLine();

Game game = new Game(Int32.Parse(diffLvl));

game.questions = game.readQuestions(); // List of questions in the game
game.isGameActive = true;

Console.WriteLine("Witaj w grze Milionerzy!\nPodaj swój nick: ");
game.playerName=Console.ReadLine();
Console.WriteLine("Drogi "+game.playerName+ " GL HF");
string answer;
while (game.isGameActive)
{
    if (Console.ReadKey().Key == ConsoleKey.X)
        game.isGameActive = false;
    Console.WriteLine("Pytanie numer {0}",game.roundNumber);
    Console.WriteLine(game.questions[game.roundNumber].question);
    Console.WriteLine(game.questions[game.roundNumber].answerA);
    Console.WriteLine(game.questions[game.roundNumber].answerB);
    Console.WriteLine(game.questions[game.roundNumber].answerC);
    Console.WriteLine(game.questions[game.roundNumber].answerD);

    Console.WriteLine("Podaj odpowiedź");
    answer = Console.ReadLine();
    if (game.questions[game.roundNumber].isAnswerCorrect(answer))
    {
        Console.WriteLine("Gratulacje dobra odpowiedź!");
    }
    else
    {
        Console.WriteLine("Niestety, odpowiedź {0} jest nieprawidłowa.\n Prawidłowa " +
            "odpowiedź to {1}", answer, game.questions[game.roundNumber].correctAnswer);
        game.isGameActive = false;
    }

    game.roundNumber++;
    
}
game.isGameActive = false;

Console.WriteLine("Game"+game.roundNumber);
Console.ReadKey();
