namespace Exam
{
    public abstract class Question
    {
        #region Properties 

        public abstract string Header { get; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }

        #endregion

        #region Methods 
        public Question()
        {
            RightAnswer = new Answer();
            UserAnswer = new Answer();

        }


        public abstract void AddQuestion();

        public override string ToString()
            => $"{Header} \t Mark : {Mark}" +
            $"\n {Body}";
        #endregion


    }
}
