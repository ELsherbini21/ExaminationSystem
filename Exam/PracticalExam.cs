namespace Exam
{
    public class PracticalExam : Exam
    {


        public PracticalExam(int _time, int _numOfQuestion) : base(_time, _numOfQuestion)
        {

        }


        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new McqQuestion[NumberOfQuestions];

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                ListOfQuestions[i] = new McqQuestion();
                ListOfQuestions[i].AddQuestion();
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

            Console.WriteLine($"\t\t  Right Answer \t\t ");

            if (ListOfQuestions is not null)
                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    Console.WriteLine($"Question : {i + 1} : {ListOfQuestions[i].Body}");
                    Console.WriteLine($"Right answer : {ListOfQuestions[i].RightAnswer.AnswerText} ");
                }








        }
    }
}
