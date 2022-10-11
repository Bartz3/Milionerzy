using Milionerzy;
using System.Text;

void show(string s)
{
    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
    Console.WriteLine(s);
}
Console.WriteLine("Nowa gra");
Console.WriteLine("Ustawienia");
Console.WriteLine("Rekordy");
Console.WriteLine("Wyjście");

//Console.WriteLine("Wybierz poziom trudnośći");
//Console.Write("1. Łatwy \t\t");
//Console.Write("2. Średni\t\t");
//Console.Write("3. Trudny\n");
//
//string diffLvl = Console.ReadLine();
//Game game = new Game(Int32.Parse(diffLvl));

Game game = new Game(1);

game.questions = game.readQuestions(); // List of questions in the game
game.isGameActive = true;



//Console.WriteLine("Witaj w grze Milionerzy!\nPodaj swój nick: ");
//game.playerName=Console.ReadLine();
//Console.WriteLine("Drogi "+game.playerName+ " GL HF");
string answer;
while (game.isGameActive && game.roundNumber<13)
{
    //if (Console.ReadKey().Key == ConsoleKey.X)
    //    game.isGameActive = false;
    
    //game.changeQuestion(game.roundNumber); // Zamiana pytania
    //game.fiftyFifty(game.roundNumber); // Pół na pół
    game.showPrizes(game.roundNumber);
    Console.WriteLine("Pytanie numer {0}",game.roundNumber);
    Console.WriteLine(game.questions[game.roundNumber].question);
    Console.Write(game.questions[game.roundNumber].answerA +"\t\t");
    Console.WriteLine(game.questions[game.roundNumber].answerB);
    Console.Write(game.questions[game.roundNumber].answerC + "\t\t");
    Console.WriteLine(game.questions[game.roundNumber].answerD);
    
    Console.WriteLine("Podaj odpowiedź:");
    answer = Console.ReadLine();

    if (game.questions[game.roundNumber].isAnswerCorrect(answer))
    {
        Console.WriteLine("Gratulacje dobra odpowiedź!");
        Console.WriteLine("Twój stan konta to:{0}", game.Prizes[game.roundNumber]);
    }
    else
    {
        Console.WriteLine("Niestety, odpowiedź {0} jest nieprawidłowa.\n Prawidłowa " +
            "odpowiedź to {1}", answer, game.questions[game.roundNumber].correctAnswer);
        game.isGameActive = false;
    }
    if (game.roundNumber == 13) { 
        Console.WriteLine("GZ wygrałeś dużo");
    }

    

    game.roundNumber++;
    
}
game.isGameActive = false;
Console.WriteLine(game.roundNumber);
Console.ReadKey();
