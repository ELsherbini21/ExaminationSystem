namespace Exam
{
    public class TrueFalseQuestion : Question
    {
        public override string Header
        {
            get => "True_False Question";

        }

        public TrueFalseQuestion()
        {
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer(1, "True");
            AnswerList[1] = new Answer(2, "False");
        }


        private void InsertBodyOfQuestion()
        {
            Console.WriteLine("Enter The Body Of Question");
            this.Body = Console.ReadLine();
        }

        private void InsertMarkOfQuestion()
        {
            int mark;
            bool Flag;
            do
            {
                Console.WriteLine("Enter Mark Of Question");
                Flag = int.TryParse(Console.ReadLine(), out mark);
            } while (!(Flag));
            this.Mark = mark;
        }

        private void EnterRightAnswerByID()
        {
            int rightAnswer;
            bool flag;
            do
            {
                Console.WriteLine("Enter Right Answer By ID ==> \t 1.True   2.False");
                flag = int.TryParse(Console.ReadLine(), out rightAnswer);
            } while (!(flag = true && (rightAnswer >= 1 && rightAnswer <= 2)));

            RightAnswer.AnswerId = rightAnswer;
        }

        private void SetRightAnswerText()
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
            Console.WriteLine(Header);
            InsertBodyOfQuestion();
            InsertMarkOfQuestion();
            EnterRightAnswerByID();
            SetRightAnswerText();
        }
    }

}
