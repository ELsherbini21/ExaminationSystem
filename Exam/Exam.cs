using System.Runtime.CompilerServices;

namespace Exam
{
    public abstract class Exam
    {
        #region Properties 

        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] ListOfQuestions { get; set; }

        #endregion


        #region Methods

        public Exam(int _time, int _numberOfQuestions)
        {
            this.Time = _time;
            this.NumberOfQuestions = _numberOfQuestions;

        }
        public Exam()
        {

        }

        public abstract void CreateListOfQuestions();
        public abstract void ShowExam();

        #endregion

    }
}
