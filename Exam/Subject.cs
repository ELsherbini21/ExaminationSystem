using System.Diagnostics;
using System.Threading.Channels;

namespace Exam
{
    public class Subject
    {
        #region Properties 

        public int Id { get; set; }
        public string Name { get; set; }
        public Exam SubjectExam { get; set; }

        #endregion

        #region Methods
        public Subject(int _id, string _name)
        {
            this.Id = _id;
            this.Name = _name;
        }

        public int InsertExamType()
        {
            int choiceNumber;
            bool flagChoiceNumber;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the type of exam \t 1.Practical    2.Final  ");
                flagChoiceNumber = int.TryParse(Console.ReadLine(), out choiceNumber);

            } while (!(flagChoiceNumber == true && (choiceNumber == 1 || choiceNumber == 2)));

            return choiceNumber;
        }

        public int InsertExamTime()
        {
            int timeOfExam;
            bool flagChoiceNumber;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the Time of exam  ");
                flagChoiceNumber = int.TryParse(Console.ReadLine(), out timeOfExam);

            } while (!(flagChoiceNumber == true));

            return timeOfExam;
        }

        public int InsertNumberOfQuestions()
        {
            int numberOfQuestion;
            bool flagChoiceNumber;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter Number Of Questions  ");
                flagChoiceNumber = int.TryParse(Console.ReadLine(), out numberOfQuestion);

            } while (!(flagChoiceNumber == true));

            return numberOfQuestion;
        }

        public void CreateExam()
        {
            int examType, time, numberOfQuestion;

            examType = InsertExamType();
            time = InsertExamTime();
            numberOfQuestion = InsertNumberOfQuestions();

            if (examType == 1)
            {
                SubjectExam = new PracticalExam(time, numberOfQuestion);
            }
            else if (examType == 2)
            {
                SubjectExam = new FinalExam(time, numberOfQuestion);
            }
            SubjectExam.CreateListOfQuestions();
            Console.Clear();
        }

        #endregion

    }
}
