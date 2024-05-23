using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count() < 5 ) {
                throw new InvalidOperationException();
            }

            var procent = Students.Count() * 0.2;
            
            int procentv2 = ((int)procent);
            int x = 0;

            for (int i = 0; i < Students.Count;i++)
            {
                var s = Students[i];
                if (s.AverageGrade > averageGrade)
                {
                    x++;
                }
            }

            if(x < procentv2)
            {
                return 'A';
            }
            x = x - procentv2;

            if (x < procentv2)
            {
                return 'B';
            }
            x = x - procentv2;

            if (x < procentv2)
            {
                return 'C';
            }
            x = x - procentv2;

            if (x < procentv2)
            {
                return 'D';
            }
            return 'F';
            
        }
    }
}
