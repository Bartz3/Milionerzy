using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;


namespace Milionerzy
{
 
    internal class Game
    {
        private string questionFileName { get; set; } = "easy.txt"; // Name of file with questions; deafult - easy.txt
        private string resultsFileName { get; set; } = "results.txt"; // Name of file with questions; deafult - easy.txt

        public string playerName { get; set; }
        public List<Question> questions { get; set; } // List of questions
        public int roundNumber { get; set; } =0; // Number of round         
       
        public bool isGameActive { get; set; } = false; // Indicates if game is active
        private bool fiftyFiftyBool { get; set; } = true; // First help bool
        private bool changeQuestionBool { get; set; } = true; // Second help bool
        private bool askAudienceBool { get; set; } = true; // Third help bool


        private string logo = @"
            .___  ___.  __   __       __    ______   .__   __.  _______ .______      ________  ____    ____ 
            |   \/   | |  | |  |     |  |  /  __  \  |  \ |  | |   ____||   _  \    |       /  \   \  /   / 
            |  \  /  | |  | |  |     |  | |  |  |  | |   \|  | |  |__   |  |_)  |   `---/  /    \   \/   /  
            |  |\/|  | |  | |  |     |  | |  |  |  | |  . `  | |   __|  |      /       /  /      \_    _/   
            |  |  |  | |  | |  `----.|  | |  `--'  | |  |\   | |  |____ |  |\  \----. /  /----.    |  |     
            |__|  |__| |__| |_______||__|  \______/  |__| \__| |_______|| _| `._____|/________|    |__|    " + "\n";
        

        private Dictionary<int, string> prizes = new Dictionary<int, string>()
        {
            {0,"0 zł"},
            {1,"500 zł"},
            {2,"1000 zł"},
            {3,"2000 zł"},
            {4,"5000 zł"},
            {5,"10 000 zł"},
            {6,"20 000 zł"},
            {7,"40 000 zł"},
            {8,"75 000 zł"},
            {9,"125 000 zł"},
            {10,"250 000 zł"},
            {11,"500 000 zł"},
            {12,"1 000 000 zł"},
        };
        public void show(string s)
        {
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
        }
        public Dictionary<int, string> Prizes { get { return prizes; } }
        private void difficultyLevelVoid(int lv)
        {
            switch (lv)
            {
                case 0: questionFileName = "easy.txt";
                    break;
                case 1:
                    questionFileName = "medium.txt";
                    break;
                case 2:
                    questionFileName = "hard.txt";
                    break;

            }
        }
        public void Start()
        {
            SoundPlayer intro = new SoundPlayer("intro.wav");
            intro.Load();
            intro.Play();
            RunMainMenu();
        }
        private void End()
        {
            SoundPlayer outro = new SoundPlayer("outro.wav");
            outro.Load();
            outro.Play();
            string won=winnerPrize(roundNumber-1, isGameActive);
            show($"Gratulacje {playerName} wygrałeś {won}");

        }
        private void preGameDisplay()
        {
            Console.Clear();
            Console.WriteLine(logo);
            Console.WriteLine("\n");
            show("Witaj w grze Milionerzy!\n");
            show("Podaj swój nick: ");
            Console.SetCursorPosition((Console.WindowWidth) / 2 +8, Console.CursorTop -1);
            playerName = Console.ReadLine();
            
            if (playerName == "") playerName = "anonim";
            show($"Witaj " + playerName + ", przed Tobą 13 pytań w drodze do miliona.");
            show("Powodzenia!");
            roundNumber = 0;
            Console.ReadKey(true);

            questions = readQuestions();
            isGameActive = true;

        }
        private string questionMethod()
        {
            string answer = null; string prompt,prompt2;
            if (roundNumber==0) prompt2 = $"Stan konta: (-/{Prizes[12]})";
            else prompt2 = $"Stan konta:({Prizes[roundNumber-1]}/{Prizes[12]})";           
             prompt = questions[roundNumber].question ;

            string[] options = {$"{questions[roundNumber].answerA}", $"{questions[roundNumber].answerB}"
                        ,$"{questions[roundNumber].answerC}",$"{questions[roundNumber].answerD}"
                        ,$"{(fiftyFiftyBool ? "Koło 50/50" : "Koło 50/50 nieaktywne")}",
            $"{(changeQuestionBool ? "Zamiana pytania" : "Zamiana pytania nie możliwa.")}",
           $"{(askAudienceBool ? "Pytanie do publiczności" : "Pytanie do publiczności nie możliwe.")}"
            ,$"Zakończ grę na pytaniu {roundNumber}"};
            Menu answersMenu = new Menu(prompt2,prompt, options);
            int selectedIndex = answersMenu.Run(1);
            
            switch (selectedIndex)
            {
                case 0:
                    answer = "a";
                    break;
                case 1:
                    answer = "b";
                    break;
                case 2:
                    answer = "c";
                    break;
                case 3:
                    answer = "d";
                    break;
                case 4:
                    fiftyFifty(roundNumber);
                    break;
                case 5:
                    changeQuestion(roundNumber);
                    
                    break;
                case 6:              
                    askAudience(roundNumber);
                    
                    break;
                case 7:
                    isGameActive = false;
                    //saveResult(winnerPrize(roundNumber, isGameActive));

                    //winnerPrize(roundNumber, isGameActive);
                    End();
                    show("Wciśnij dowolny przycisk aby kontynuować.");
                    resetGame();
                    Console.ReadKey();
                    RunMainMenu();
                    break;

            }
            return answer;

        }
        public void startGame()
        {
            //preGameDisplay();
            string answer;
            while (isGameActive && roundNumber < 13)
            {

                answer = questionMethod();
                while (answer == null) answer = questionMethod();
                
                if (questions[roundNumber].isAnswerCorrect(answer))
                {
                    //Console.WriteLine("\n");
                    if (roundNumber == 2 || roundNumber == 7)
                    {
                        show("Gratulacje dobra odpowiedź! Uzyskałeś próg gwarantowany!");
                        show($"Twój stan konta to:{Prizes[roundNumber]}");
                    }
                    else
                    {
                        show("Gratulacje dobra odpowiedź!");
                        show($"Twój stan konta to:{Prizes[roundNumber]}");
                    }

                    showPrizes(roundNumber);
                    Console.ReadKey();
                }
                else
                {
                    //Console.WriteLine("\n");
                    show($"Niestety, odpowiedź {answer} jest nieprawidłowa." +
                        $" Prawidłowa odpowiedź to {questions[roundNumber].correctAnswer}. Zakończyłeś grę na pytaniu numer {roundNumber}.");
                    SoundPlayer badAnswer = new SoundPlayer("badAnswer.wav");
                    badAnswer.Load();
                    badAnswer.Play();


                    var winnings = winnerPrize(roundNumber, isGameActive);
                    //saveResult(winnings);
                    isGameActive = false;

                }
                if (roundNumber == 12)
                {

                    //saveResult(prizes.GetValueOrDefault(12));
                    Console.WriteLine(@"
                   
                                     __        __                                 _ 
                                     \ \      / /   _  __ _ _ __ __ _ _ __   __ _| |
                                      \ \ /\ / / | | |/ _` | '__/ _` | '_ \ / _` | |
                                       \ V  V /| |_| | (_| | | | (_| | | | | (_| |_|
                                        \_/\_/  \__, |\__, |_|  \__,_|_| |_|\__,_(_)
                                                |___/ |___/                         

                    ");
                    show($"Gratulacje {playerName} wygrałeś w grze Milionerzy!");
                    SoundPlayer outro = new SoundPlayer("outro.wav");
                    outro.Load();
                    outro.Play();
                    isGameActive = false;
                }
                roundNumber++;
                //gameLogic(answer);

            }
            isGameActive = false;
            resetGame();

            show("Naciśnij dowolny przycisk aby przejść do głównego menu...");

            Console.ReadKey(true);
            RunMainMenu();
        }
        private void RunMainMenu()
        {
            string[] options = { "Nowa gra", "Ustawienia", "Ostatnie wyniki", "Wyjście" };
            Menu mainMenu = new Menu(logo, options);
            int selectedIndex = mainMenu.Run(0);

            switch (selectedIndex)
            {
                case 0:
                    startGame();
                    break;
                case 1:
                    pickDifficultyLevel();
                    break;
                case 2:
                    Console.Clear();
                    showLastResults();
                    break;
                case 3:                   
                    exitGame();
                    break;
            }
        }
        
        private void pickDifficultyLevel()
        {
            string prompt = "Wybierz poziom trudności";
            string[] options = { "1. Łatwy", "2. Średni", "3. Trudny", "Wróć do menu" };

            Menu levelMenu = new Menu(prompt, options);
            int selectedIndex = levelMenu.Run(1);

            switch (selectedIndex)
            {
                case 0:
                    difficultyLevelVoid(0);
                    show("Wybrałeś poziom łatwy."); Console.ReadKey(true);
                    RunMainMenu();
                    break;
                case 1:
                    difficultyLevelVoid(1);
                    show("Wybrałeś poziom średni."); Console.ReadKey(true);
                    RunMainMenu();

                    break;
                case 2:
                    show("Wybrałeś poziom trudny.");
                    difficultyLevelVoid(2);
                    Console.ReadKey(true);
                    RunMainMenu();
                    break;
                case 3:
                    RunMainMenu();
                    break;
            }

        }
        private void exitGame()
        {
            show("Wciśnij dowolny przycisk aby wyjść...");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine(logo);
            show("Do następnego razu!");
            Environment.Exit(0);
        }
        private void resetGame()
        {
            askAudienceBool = true;
            changeQuestionBool = true;
            fiftyFiftyBool = true;
        }
        private void showLastResults()
        {
            show("Ostatnie wyniki:\n");
            
            using (StreamReader sr = new StreamReader(resultsFileName))
            {                
                while(!sr.EndOfStream)
                     show(sr.ReadLine());
            }
            show("\n");
            show("Naciśnij dowolny przycisk aby przejść do głównego menu...");
            Console.ReadKey(true);
            RunMainMenu();
        }
        private void saveResult(string winnings)
        {
            string currentContent = String.Empty;
            if (File.Exists(resultsFileName))
            {
                currentContent = File.ReadAllText(resultsFileName);
            }
            var eee = $"{playerName} - {winnings}";
            File.WriteAllText(resultsFileName, eee +"\n"+ currentContent);
       
        }
        public void showPrizes(int qNumber)
        {
            foreach (KeyValuePair<int, string> item in Prizes.Reverse())
            {
                if (item.Key == qNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    show($"{item.Key}. {item.Value}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if(item.Key==2 || item.Key == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    show($"{item.Key}. {item.Value}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else show($"{item.Key}. {item.Value}");
            }
        }
        private string winnerPrize (int qNumber,bool activeGame)
        {
            if (qNumber < 2 && activeGame)
            {
                show("Niestety nie udało Ci się wygrać :(");
                saveResult("0zł");
                return "0zł";
            }
            else if (qNumber >= 2 && qNumber < 7 && activeGame)
            {
                show("Wygrałeś 1000zł!");
                saveResult("1000zł");
                return "1000zł";
            }
            else if (qNumber >= 7 && activeGame)
            {
                show("Wygrałeś 40 000zł!");
                saveResult("40 000zł");
                return "40 000zł";
            }
            else if (!activeGame)
            {
                foreach (KeyValuePair<int, string> item in Prizes)
                {
                    if (item.Key == qNumber)
                    {
                        
                        saveResult(item.Value.ToString());
                        return item.Value;
                    }
                }
            }
            return "0zł";
        }    
     
        public void askAudience(int qNumber)
        {
            Random rand = new Random();
            List<int> percents = new List<int>();
            int goodAnswerPercent = 0, percent1 = 0, percent2 = 0, percent3 = 0,cem=100;
            bool isUsed = false;
            if (askAudienceBool)
            {
                string correctA = questions[qNumber].correctAnswer;
                if (qNumber < 9) goodAnswerPercent = rand.Next(50, 70);
                else goodAnswerPercent = rand.Next(20, 50);

                cem -= goodAnswerPercent;

                percent1 = rand.Next(0, cem);
                cem -= percent1;

                percent2 = rand.Next(0, cem);
                cem -= percent2;

                percent3 = cem;

                if (questions[qNumber].answerA.Substring(0, 1) == correctA)
                {
                    questions[qNumber].answerA = questions[qNumber].answerA+" " +goodAnswerPercent.ToString()+"%";
                    questions[qNumber].answerB = questions[qNumber].answerB+" " +percent1.ToString()+"%";
                    questions[qNumber].answerC = questions[qNumber].answerC+" " +percent2.ToString()+"%";
                    questions[qNumber].answerD = questions[qNumber].answerD+" " +percent3.ToString()+"%";
                }
                if (questions[qNumber].answerB.Substring(0, 1) == correctA)
                {
                    questions[qNumber].answerB = questions[qNumber].answerB + " " + goodAnswerPercent.ToString() + "%";
                    questions[qNumber].answerA = questions[qNumber].answerA + " " + percent1.ToString() + "%";
                    questions[qNumber].answerC = questions[qNumber].answerC + " " + percent2.ToString() + "%";
                    questions[qNumber].answerD = questions[qNumber].answerD + " " + percent3.ToString() + "%";
                }
                if (questions[qNumber].answerC.Substring(0, 1) == correctA)
                {
                    questions[qNumber].answerC =questions[qNumber].answerC + " " + goodAnswerPercent.ToString() + "%";
                    questions[qNumber].answerA = questions[qNumber].answerA + " " + percent1.ToString() + "%";
                    questions[qNumber].answerB = questions[qNumber].answerB + " " + percent2.ToString() + "%";
                    questions[qNumber].answerD = questions[qNumber].answerD + " " + percent3.ToString() + "%";
                }
                if (questions[qNumber].answerD.Substring(0, 1) == correctA)
                {
                    questions[qNumber].answerD = questions[qNumber].answerD + " " + goodAnswerPercent.ToString() + "%";
                    questions[qNumber].answerA = questions[qNumber].answerA + " " + percent1.ToString() + "%";
                    questions[qNumber].answerB = questions[qNumber].answerB + " " + percent2.ToString() + "%";
                    questions[qNumber].answerC = questions[qNumber].answerC + " " + percent2.ToString() + "%";

                }
                askAudienceBool = false;
            }
        }
        private void fiftyFifty(int qNumber) // Pierwsze koło ratunkowe 50/50
        {
            if (fiftyFiftyBool)
            {
                string correctA = questions[qNumber].correctAnswer;
                int deletedAnswers = 0;

                if (questions[qNumber].answerA.Substring(0, 1) != correctA && deletedAnswers < 2)
                {
                    questions[qNumber].answerA = "XXX";
                    deletedAnswers++;
                }
                if (questions[qNumber].answerB.Substring(0, 1) != correctA && deletedAnswers < 2)
                {
                    questions[qNumber].answerB = "XXX";
                    deletedAnswers++;
                }
                if (questions[qNumber].answerC.Substring(0, 1) != correctA && deletedAnswers < 2)
                {
                    questions[qNumber].answerC = "XXX";
                    deletedAnswers++;
                }
                if (questions[qNumber].answerD.Substring(0, 1) != correctA && deletedAnswers < 2)
                {
                    questions[qNumber].answerD = "XXX";
                    deletedAnswers++;
                }
                fiftyFiftyBool = false;
            }

        }
        private void changeQuestion(int qNumber)
        {
            if (changeQuestionBool)
            {
                var temp = qNumber.ToString() + ". " + questions[13].question.Substring(questions[13].question.IndexOf('.') + 1);
                questions[qNumber].question = temp;
                questions[qNumber].answerA = questions[13].answerA;
                questions[qNumber].answerB = questions[13].answerB;
                questions[qNumber].answerC = questions[13].answerC;
                questions[qNumber].answerD = questions[13].answerD;
                questions[qNumber].correctAnswer = questions[13].correctAnswer;

                changeQuestionBool = false;
            }
        }
 
        public List<Question> readQuestions()
        {
            List<Question> questionList = new List<Question>();

            using (StreamReader sr = new StreamReader(questionFileName,Encoding.UTF8))
            {
                int i = 0, questionNumber = -1;
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    switch (i)
                    {
                        case 0:
                            questionNumber++;
                            questionList.Add(new Question());
                            questionList[questionNumber].numberOfQuestion = questionNumber;
                            questionList[questionNumber].question = line;
                            break;
                        case 1:
                            questionList[questionNumber].answerA = line;
                            break;
                        case 2:
                            questionList[questionNumber].answerB = line;
                            break;
                        case 3:
                            questionList[questionNumber].answerC = line;
                            break;
                        case 4:
                            questionList[questionNumber].answerD = line;
                            break;
                        case 5:
                            questionList[questionNumber].correctAnswer = line;
                            break;
                        default:
                            break;
                    }
                    i++; i = i % 6;                   
                }
            }
            return questionList;
        }
    }
}
