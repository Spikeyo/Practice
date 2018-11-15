//****************************************************************
// Solution for the GradeSchool exercise in Exercism.io
//
// ~Spikeyo
//****************************************************************

using System.Collections.Generic;
using System.Linq;

namespace GradeSchoolProject
{
    public class GradeSchool
    {
        private readonly List<Student> _students = new List<Student>();

        public void Add(string student, int grade)
        {
            _students.Add(
                new Student
                {
                    name = student, 
                    grade = grade 
                });
        }

        public IEnumerable<string> Roster()
        {
            var sortedStudents = _students.OrderBy(x => x.grade).ThenBy(x => x.name);
        
            return sortedStudents.Select(x => x.name);
        }

        public IEnumerable<string> Grade(int grade)
        {
            var sortedStudents = _students.Where(x => x.grade == grade).OrderBy(x => x.name);
            
            return sortedStudents.Select(x => x.name);
        }
    }
}