using IstanbulUniKendo.BAL.Abstract;
using IstanbulUniKendo.DAL.Abstract;
using IstanbulUniKendo.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUniKendo.BAL.Concrate
{
    public class StudentManager : IStudentService
    {
        IStudent _student;
      
        public StudentManager(IStudent student)
        {
            _student = student;
        }

        public Student GetByID(int id)
        {
            return _student.get(x => x.ID == id);
        }

        public List<Student> GetListBl()
        {
            return _student.List();
        }

        public void StudentAddBl(Student student)
        {
            var entity = new Student();

            entity.Name = student.Name;
            entity.Surname = student.Surname;
            entity.UniversityName = student.UniversityName;
            entity.StudentNo = student.StudentNo;
            entity.examScore = student.examScore;
            _student.Insert(entity);
        }

        public bool StudentRemoveBl(Student student)
        {
            var _studentInfo = _student.get(t => t.ID == student.ID);
            if (_studentInfo != null)
            {
                _student.Delete(student);

                return true;
            }
            else
            {
                return false;
            }
        }

        public void StudentUpdateBl(Student student)
        {
            _student.Update(student);
        }
    }
}
