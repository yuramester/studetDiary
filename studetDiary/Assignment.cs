using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studetDiary
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Subject Subject { get; set; }
        public DateTime Deadline { get; set; }
        public AssignmentStatus Status { get; set; }

        public Assignment() { }

        public Assignment(int id, string title, string description, Subject subject, DateTime deadline, AssignmentStatus status)
        {
            Id = id;
            Title = title;
            Description = description;
            Subject = subject;
            Deadline = deadline;
            Status = status;
        }

        public string GetInfo()
        {
            return $"{Title} | {Subject.Name} | {Deadline.ToShortDateString()} | {Status}";
        }

        public void UpdateStatus(AssignmentStatus status)
        {
            Status = status;
        }
    }
}