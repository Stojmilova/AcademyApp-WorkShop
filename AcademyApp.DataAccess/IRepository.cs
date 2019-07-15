using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyApp.DataAccess
{
    public interface IRepository<T>
    {        
        T GetById(int id);
        List<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void DeleteById(int id);
    }
}
