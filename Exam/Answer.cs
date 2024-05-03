using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Answer
    {
        #region Properties

        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        #endregion



        #region Methods
        public Answer(int _id, string _text)
        {
            this.AnswerId = _id;
            this.AnswerText = _text;

        }
        public Answer()
        {
            this.AnswerId = 0;
            this.AnswerText = null;
        }

        public override string ToString()
            => $"{AnswerId} - {AnswerText}";


        #endregion

    }
}
