
using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using Question_02.Models;

using System.Data.Entity;
 
namespace Question_02.Models.Repository

{

    public class Repository<T> : IRepository<T> where T : class

    {

        MovieContext mc;

        DbSet<T> dbset;

        public Repository()

        {

            mc = new MovieContext();

            dbset = mc.Set<T>();

        }

        //Implementation

        public IEnumerable<T> GetAll()

        {

            return dbset.ToList();

        }

        public T GetById(object Mid)

        {

            return dbset.Find(Mid);

        }

        public void Insert(T obj)

        {

            dbset.Add(obj);

        }

        public void Update(T obj)

        {

            mc.Entry(obj).State = EntityState.Modified;

        }

        public void Delete(object Mid)

        {

            T getModel = dbset.Find(Mid);

            dbset.Remove(getModel);

        }

        public void Save()

        {

            mc.SaveChanges();

        }

    }

}