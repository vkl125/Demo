using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.Entities.ViewModel
{
    public class EventScheduleViewModel
    {
        public int ID { get; set; }
        public DateTime EffectiveDt { get; set; }
        public DateTime StartDt { get; set; }
        public DateTime? EndDt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime ModifiedDt { get; set; }
        public int ModifiedBy { get; set; }
        public int ReminderID { get; set; }
        //public bool NoEndDate { get; set; }
        //public bool Repeatable { get; set; }
        //public char Frequency { get; set; }//W,B,C
        //public bool RepeatDays { get; set; }
        //public string DaysOfWeek { get; set; }
        //public string CustomFrequency { get; set; }
    }
}
