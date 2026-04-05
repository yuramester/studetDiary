using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace studetDiary
{
    public class AssignmentManager
    {
        public List<Assignment> Assignments { get; set; }
        public List<Subject> Subjects { get; set; }

        public AssignmentManager()
        {
            Assignments = new List<Assignment>();
            Subjects = new List<Subject>();
        }

        public void AddAssignment(Assignment a)
        {
            Assignments.Add(a);
        }

        public void DeleteAssignment(int id)
        {
            var a = Assignments.FirstOrDefault(x => x.Id == id);
            if (a != null)
                Assignments.Remove(a);
        }

        public List<Assignment> FindAssignment(string query)
        {
            return Assignments
                .Where(a => a.Title.Contains(query))
                .ToList();

        }

        public void ChangeStatus(int id, AssignmentStatus status)
        {
            var a = Assignments.FirstOrDefault(x => x.Id == id);
            if (a != null)
                a.Status = status;
        }
    }
}
