using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;

        }

        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; } //blank for read only
        public string SubmitterName { get; } //blank for readonly

        public string LetterGrade

        {
            get
            {
                if (EarnedMarks >= 90)
                {
                    return "A";
                }
                else if (EarnedMarks >= 80 && EarnedMarks <= 89)
                {
                    return "B";
                }
                else if (EarnedMarks >= 70 && EarnedMarks <= 79)
                {
                    return "C";
                }
                else if (EarnedMarks >= 60 && EarnedMarks <= 69)
                {
                    return "D";
                }
                else
                    return "F";
            }
        }

    }
}
