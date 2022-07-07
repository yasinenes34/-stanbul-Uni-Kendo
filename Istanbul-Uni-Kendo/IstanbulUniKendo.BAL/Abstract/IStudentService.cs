using IstanbulUniKendo.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUniKendo.BAL.Abstract
{
    public interface IStudentService
    {
        List<Student> GetListBl();
        void StudentAddBl(Student student);
        bool StudentRemoveBl(Student student);
        Student GetByID(int id);
        void StudentUpdate(Student student);
    }
}
