using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    public class Timeslot
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Timeslot(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public bool Overlaps(Timeslot other)
        {
            return Start < other.End && other.Start < End;
        }
    }
}
