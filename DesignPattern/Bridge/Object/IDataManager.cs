using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Object
{
    public interface IDataManager<T> where T : class 
    {
        IList<T> GetAll();
        IList<T> GetAll(Func<T, bool> expression);
        T GetById(int id);
        T Get(Func<T, bool> expression);      
        void AddRecord(T Object);
        void DeleteRecord(T Object);
        IList<T> NextRecord();
        IList<T> PriorRecord();
        IList<T> ShowAllRecord();
        void DeleteRecord(int id);
        void DeleteRecord();
        void AddRecord();
    }
   

}
