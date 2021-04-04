using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Object
{
    public class StudentBusiness : StudentBusinessBase
    {
        public StudentBusiness(List<StudentBusiness> students) : base(students)
        {
            base.GetAll();
        }

        public override void Add(StudentBusiness student)
        {
            base.Add(student);
        }
        public override void Delete(StudentBusiness student)
        {
            base.Delete(student);
        }
        public override List<StudentBusiness> Next()
        {
            return base.Next();
        }
        public override List<StudentBusiness> Prior()
        {
            return base.Prior();
        }
              
        internal override List<StudentBusiness> ShowAll()
        {
            return _students;
        }
        internal override List<StudentBusiness> GetAll(StudentBusiness students)
        {
            return _students;
        }
    }
}
 