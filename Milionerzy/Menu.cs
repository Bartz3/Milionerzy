using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy
{
    public class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;
        private string Prompt2;

        public Menu(string prompt, string[] options)
        {
            this.Prompt = prompt;
            this.Options = options;
            SelectedIndex = 0;
        }
        public Menu(string prompt,string prompt2, string[] options)
        {
            this.Prompt = prompt;
            this.Prompt2 = prompt2;
            this.Options = options;
            SelectedIndex = 0;
        }

        public int Run(int option)
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                if(option == 0)
                {
                    DisplayOptions();
                }
                if (option == 1) {DisplayQuestions(); }
                    

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1) SelectedIndex = Options.Length - 1; // SelectedIndex at last position of the options array
                }
                else if(keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if(SelectedIndex == Options.Length) SelectedIndex = 0;
                }
                

            } while (keyPressed != ConsoleKey.Enter);


            return SelectedIndex;
        }
        private void DisplayOptions()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix="";
                if (i == SelectedIndex)
                {
                    prefix = "*";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                show($"{prefix}<{currentOption}>");
            }
            Console.ResetColor();
        }
    
        private void DisplayQuestions()
        {

            //Console.WriteLine(Prompt);
            show(Prompt);
            show(Prompt2);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix = "";
                if (i == SelectedIndex)
                {
                    prefix = "*";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                show($"{prefix}{currentOption}");
            }
            Console.ResetColor();

        }


        void show(string s)
        {

                Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                Console.WriteLine(s);
            
     
        }

    }
}