using IstanbulUniKendo.DAL.Abstract;
using IstanbulUniKendo.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUniKendo.DAL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        IUKendoContext db = new IUKendoContext();
        public void Delete(T d)
        {
            throw new NotImplementedException();
        }

        public T get(Expression<Func<T, bool>> filiter)
        {
            throw new NotImplementedException();
        }

        public void Insert(T d)
        {
            throw new NotImplementedException();
        }

        public List<T> List()
        {
            throw new NotImplementedException();
        }

        public List<T> List(Expression<Func<T, bool>> filiter)
        {
            throw new NotImplementedException();
        }

        public void Update(T d)
        {
            throw new NotImplementedException();
        }
    }
}
