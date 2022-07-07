using IstanbulUniKendo.DAL.Abstract;
using IstanbulUniKendo.DAL.Model;
using IstanbulUniKendo.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUniKendo.DAL.EntityFramework
{
    public class EfUserDal:GenericRepository<User>,IUser
    {
    }
}
