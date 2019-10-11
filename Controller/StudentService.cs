using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppG2.Model;
namespace AppG2.Controller
{
    public class StudentService
    {
        /// <summary>
        /// Lấy sinh viên theo mã sinh viên
        /// </summary>
        /// <param name=""
        /// <param name="idStudent">Mã sinh viên</param>
        /// <returns>Sinh viên có mã tương ứng hoặc null</returns>
        public static Student GetStudent(string idStudent, string maSinhVien)
        {
            Student student = new Student
            {
                IDStudent = idStudent,
                FirstName = "Loi",
                LastName = "Duong",
                DOB = new DateTime(2000, 01, 01),
                POB = "Thừa Thiên Huế",
                Gender = GENDER.Male
            };
            student.ListHistoryLearning = new List<HistoryLearning>();
            for (int i = 1; i <= 12; i++)
            {
                HistoryLearning historyLearning = new HistoryLearning
                {
                    IDHistoryLearning = i.ToString(),
                    YearFrom = 2006 + i,
                    YearEnd = 2007 + i,
                    Address = "THCS Phu Xuan",
                    IDStudent = idStudent,
                };
                student.ListHistoryLearning.Add(historyLearning);
            }
            return student;
        }
    }
  
}