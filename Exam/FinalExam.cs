using System.ComponentModel;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

namespace Exam
{
    public class FinalExam : Exam

    {

        public FinalExam(int _time, int _numOfQuestions) : base(_time, _numOfQuestions)
        {

        }

        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new Question[NumberOfQuestions];
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int choice = 0;
                bool flagchoice;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter Type Of Exam ==> 1.MCQ    2.True_False");
                    flagchoice = int.TryParse(Console.ReadLine(), out choice);
                } while (!(flagchoice == true && (choice == 1 || choice == 2)));

                if (choice == 1)
                {
                    ListOfQuestions[i] = new McqQuestion();
                    ListOfQuestions[i].AddQuestion();
                }
                else if (choice == 2)
                {
                    ListOfQuestions[i] = new TrueFalseQuestion();
                    ListOfQuestions[i].AddQuestion();
                }



            }
        }



        public int GetUserAnswerNumberFromUser()
        {
            int userAnswer;
            bool flagUserNum;
            do
            {
                Console.WriteLine("Enter you Answers ");
                flagUserNum = int.TryParse(Console.ReadLine(), out userAnswer);
            } while (!(flagUserNum == true && (userAnswer >= 1 && userAnswer <= 3)));
            return userAnswer;
        }


        public override void ShowExam()
        {


            if (ListOfQuestions is not null)

                foreach (var Question in ListOfQuestions)
                {
                    Console.WriteLine(Question);

                    for (int i = 0; i < Question.AnswerList.Length; i++)
                        Console.WriteLine(Question.AnswerList[i]);

                    Console.WriteLine("--- ---- --- --- --- --- --- --- ---");

                    Question.UserAnswer.AnswerId = GetUserAnswerNumberFromUser();

                    Question.UserAnswer.AnswerText = Question
                                       .AnswerList[Question.UserAnswer.AnswerId - 1].AnswerText;


                }

            Console.Clear();

            int totalMark = 0, grade = 0;

            if (ListOfQuestions is not null)
                for (int i = 0; i < ListOfQuestions.Length; i++)
                {
                    totalMark += ListOfQuestions[i].Mark;
                    if (ListOfQuestions[i].RightAnswer.AnswerId == ListOfQuestions[i].UserAnswer.AnswerId)
                    {
                        grade += ListOfQuestions[i].Mark;
                    }
                    Console.WriteLine($"Question {i + 1} \t {ListOfQuestions[i].Body}");
                    Console.WriteLine($"Your Answer = {ListOfQuestions[i].UserAnswer.AnswerText} ");
                }
            Console.WriteLine($" Your grade is = {grade} From {totalMark} ");







        }
    }
}
