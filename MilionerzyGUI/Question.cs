using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy
{
    public class Question
    {
        public int numberOfQuestion { get; set; }
        public string question { get; set; }
        public string answerA { get; set; }
        public string answerB { get; set; }
        public string answerC { get; set; }
        public string answerD { get; set; }
        public string correctAnswer { get; set; }

       public bool isAnswerCorrect(string answer)
        {
            answer = answer.Substring(0,1);
            if(answer.Equals(correctAnswer))return true;
            else return false;
        }

    }
}
