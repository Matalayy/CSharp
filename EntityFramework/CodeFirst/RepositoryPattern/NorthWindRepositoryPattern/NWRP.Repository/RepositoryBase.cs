using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWindRepositoryPatern.ORM.Models;

namespace NWRP.Repository
{
    public class RepositoryBase<T> where T:class
    {
        private static NORTHWNDContext context;
        //singleton pattern
        public  NORTHWNDContext Context
        {
            get {
                if (context == null)
                    context = new NORTHWNDContext();
                return context;
            }
            set { context = value; }
        }

        public IList<T> Listed()
        {
            return Context.Set<T>().ToList();
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
            Context = new NORTHWNDContext();
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
            Context = new NORTHWNDContext();
        }

        public void Update()
        {
            Context.SaveChanges();
        }
    }
}
