using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSchedule
{
    [Serializable]
    public class PotentialDay
    {
        public DayOfWeek DayOfWeek;
        public string TimeOfStart;
        public string TimeOfEnding;
        public PotentialDay(DayOfWeek dayofweek, string timeofstart, string timeofending)
        {
            DayOfWeek=dayofweek;
            TimeOfStart = timeofstart;
            TimeOfEnding = timeofending;

        }

        public PotentialDay() { }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            PotentialDay bd = (PotentialDay)obj;
            return (DayOfWeek == bd.DayOfWeek) && (TimeOfStart == bd.TimeOfStart) && (TimeOfEnding==bd.TimeOfEnding);
        }
    }
}
