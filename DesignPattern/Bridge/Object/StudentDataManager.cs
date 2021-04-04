using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Object
{
    public class StudentDataManager : IDataManager<Student>
    {
        
        public List<Student> _students;
        private int _current = 0;
        public StudentDataManager(List<Student> students)
        {
            _students = students;
        }
        public void AddRecord(Student Object)
        {
            _students.Add(Object);
        }

        public void AddRecord()
        {
            
        }

        public void DeleteRecord(int id)
        {
            _students.Remove(GetById(id));
        }

        public void DeleteRecord(Student Object)
        {
            var e = _students.Where(p => p.Id == Object.Id).FirstOrDefault();
            if (e != null)
                _students.Remove(e);
        }

        public void DeleteRecord()
        {
          
        }

        public Student Get(Func<Student, bool> expression)
        {
            return _students.Where(expression).FirstOrDefault();
        }

        public IList<Student> GetAll()
        {
            return _students;
        }

        public IList<Student> GetAll(Func<Student, bool> expression)
        {
            return _students.Where(expression).ToList();
        }

        public Student GetById(int id)
        {
            return _students.Where(p => p.Id == id).FirstOrDefault();
        }       
        public IList<Student> NextRecord()
        {
            if (_current <= _students.Count - 1)
            {
                _current++;
            }
            List<Student> yeniliste = new List<Student>();
            yeniliste.Add(_students[_current - 1]);                 
            return yeniliste;
        }    
        public IList<Student> PriorRecord()
        {
            if (_current > 0)
            {
                _current--;
            }
            if (_current == 0)
            {
                _current++;
            }
            List<Student> yeniliste = new List<Student>();
            yeniliste.Add(_students[_current - 1]);           
            return yeniliste;
        }      
        public IList<Student> ShowAllRecord()
        {
            List<Student> yeniliste = new List<Student>();
            return _students;
        }
    }
}
