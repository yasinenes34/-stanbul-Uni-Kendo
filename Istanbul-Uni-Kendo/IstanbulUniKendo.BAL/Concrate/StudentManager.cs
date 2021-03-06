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
        private static bool UpdateDatabase = false;
       
        IStudent _student;
      
        public StudentManager(IStudent student)
        {
            _student = student;
        }
        public List<Student> GetListBl()
        {
            return _student.List();
        }

        public Student GetByID(int id)
        {
            return _student.get(x => x.ID == id);
        }
        public IEnumerable<Student> Read()
        {
            return GetListBl();
        }
      
        public void StudentAddBl(Student student)
        {
            if (!UpdateDatabase)
            {
                var first = GetListBl().OrderByDescending(e => e.ID).FirstOrDefault();
                var id = (first != null) ? first.ID : 0;

                student.ID = id + 1;

               

                GetListBl().Insert(0, student);
            }
            else
            {
                var entity = new Student();

                entity.Name = student.Name;
                entity.Surname = student.Surname;
                entity.examScore = student.examScore;
                entity.UniversityName = student.UniversityName;
                entity.StudentNo = student.StudentNo;
                _student.Insert(entity);
            }

            _student.Insert(student);
        }

        public void StudentRemoveBl(Student student)
        {
            if (!UpdateDatabase)
            {
                var target = GetListBl().FirstOrDefault(p => p.ID == student.ID);
                if (target != null)
                {
                    _student.Delete(target);
                }
               
            }
         
        }

        public void StudentUpdateBl(Student student)
        {
            if (!UpdateDatabase)
            {
                var target = GetByID(student.ID);
                if (target != null)
                {
                    target.Name = student.Name;
                    target.Surname = student.Surname;
                    target.UniversityName = student.UniversityName;
                    target.StudentNo = student.StudentNo;
                    target.examScore = student.examScore;
                    _student.Update(target);
                }
            }
            else
            {
                var entity = new Student();
                entity.Name = student.Name;
                entity.Surname = student.Surname;
                entity.UniversityName = student.UniversityName;
                entity.StudentNo = student.StudentNo;
                entity.examScore = student.examScore;
                _student.Update(student);
            }
        }
    }

       
}


