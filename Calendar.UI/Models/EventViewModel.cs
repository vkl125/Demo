using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.Entities.ViewModel
{
    public class EventViewModel
    {
        public int ID { get; set; }
        public int CalendarID { get; set; }
        //public int ColorID { get; set; }
        //public int ReminderID { get; set; }
        public int TemplateEventID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }        
        public string Location { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public EventAvailabilityViewModel newEAVM { get; set; }
        public List<EventAvailabilityViewModel> EAVM { get; set; }
        public List<EventScheduleViewModel> ESVM { get; set; }
        //ItemSchedule
        //public int BudgetScheduleID { get; set; }
        //public DateTime StartDt { get; set; }
        //public DateTime? EndDt { get; set; }
        //public string StartT { get; set; }
        //public string EndT { get; set; }
        //public bool WholeDay { get; set; }
        //public bool NoEndDate { get; set; }
        //public bool Repeatable { get; set; }
        //public char Frequency { get; set; }//W,B,C
        //public bool RepeatDays { get; set; }
        //public string DaysOfWeek { get; set; }
        //public string CustomFrequency { get; set; }
    }
}
