using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studetDiary
{
    public class AssignmentRepository : IRepository<Assignment>
    {
        private List<Assignment> assignments;

        public AssignmentRepository()
        {
            assignments = new List<Assignment>();
        }

        public void Add(Assignment item)
        {
            assignments.Add(item);
        }

        public void Remove(int id)
        {
            var a = assignments.FirstOrDefault(x => x.Id == id);
            if (a != null)
                assignments.Remove(a);
        }

        public List<Assignment> GetAll()
        {
            return assignments;
        }

        public Assignment GetById(int id)
        {
            return assignments.FirstOrDefault(x => x.Id == id);
        }

        
        public List<Assignment> Find(string query)
        {
            return assignments
                .Where(a => a.Title.Contains(query))
                .ToList();
        }
    }
}