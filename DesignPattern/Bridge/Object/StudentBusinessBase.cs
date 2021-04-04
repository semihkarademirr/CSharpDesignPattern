using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Object
{
    public abstract class StudentBusinessBase 
    {
        internal IDataManager<StudentBusiness> DataObject { get; set; }
        public List<StudentBusiness> _students;
        public StudentBusinessBase(List<StudentBusiness> students)
        {
            _students = students;
        }

        public virtual List<StudentBusiness> Next()
        {

            return _students;

        }

        public virtual List<StudentBusiness> Prior()
        {
            return _students;
        }


        public virtual void Add(StudentBusiness Object)
        {
            DataObject.AddRecord();

        }

        public virtual void Delete(StudentBusiness Object)
        {
            DataObject.DeleteRecord();

        }

        internal abstract List<StudentBusiness> ShowAll();

        public virtual IList<StudentBusiness> GetAll()
        {
            return _students;
        }

        internal abstract List<StudentBusiness> GetAll(StudentBusiness students);

        public virtual IList<StudentBusiness> GetAll(Func<StudentBusiness, bool> expression)
        {
            return _students.Where(expression).ToList();
        }  
    }
}








    
