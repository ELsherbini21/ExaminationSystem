using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Exam
{
    public class McqQuestion : Question
    {
        public override string Header
        {
            get => "MCQ Question";
        }



        public McqQuestion()
        {
            AnswerList = new Answer[3];

        }

        public void InsertBodyOfQuestion()
        {
            Console.WriteLine("Enter The Body Of Question");
            this.Body = Console.ReadLine();
        }

        public void InsertMarkOfQuestion()
        {
            int mark;
            bool Flag;
            do
            {
                Console.WriteLine("Enter Mark Of Question [Max Mark for one Question = 5]");
                Flag = int.TryParse(Console.ReadLine(), out mark);
            } while (!(Flag == true && (mark >= 1 && mark <= 5)));
            this.Mark = mark;
        }

        public void InsertChoices()
        {
            Console.WriteLine($"Enter Choices ");
            for (int i = 0; i < AnswerList.Length; i++)
            {
                AnswerList[i] = new Answer()
                {
                    AnswerId = i + 1,
                };

                Console.WriteLine($"Enter Choice Number {i + 1}");
                AnswerList[i].AnswerText = Console.ReadLine();
            }
        }

        public void EnterRightAnswerByID()
        {
            int rightAnswer;
            bool flag;
            do
            {
                Console.WriteLine("Enter Right Answer By ID ");
                flag = int.TryParse(Console.ReadLine(), out rightAnswer);
            } while (!(flag = true && (rightAnswer >= 1 && rightAnswer <= 3)));

            RightAnswer.AnswerId = rightAnswer;
        }
        public void SetRightAnswerText()
        {
            if (AnswerList is not null)
            {

                for (int i = 0; i < AnswerList.Length; i++)
                {
                    if (AnswerList[i].AnswerId == RightAnswer.AnswerId)
                        RightAnswer.AnswerText = AnswerList[i].AnswerText;
                    return;
                }
            }
        }

        public override void AddQuestion()
        {
            Console.Clear();
            Console.WriteLine($"\t---------- {Header} ----------");
            InsertMarkOfQuestion();
            InsertBodyOfQuestion();
            InsertChoices();
            EnterRightAnswerByID();
            SetRightAnswerText();

        }
    }

}
