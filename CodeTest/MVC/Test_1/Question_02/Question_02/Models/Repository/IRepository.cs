using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Question_02.Models.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object Mid);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object Mid);
        void Save();
    }
}