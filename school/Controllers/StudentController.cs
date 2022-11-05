using school.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace school.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
       Db mydb = new Db();
        public ActionResult getStudents()
        {
            List<Student> students = new List<Student>();
            students = (from obj in mydb.Students select obj).ToList();

            return View(students);
        }
        public ActionResult detailStudent(int id)
        {
            Student student = new Student();
            student = (from obj in mydb.Students where obj.IdSt == id select obj).FirstOrDefault();
            return View();
        }
        public ActionResult addStudent()
        {
            Student student = new Student();
            student.nameSt = "name";
            student.emailSt = "email";
            student.phoneSt = "phone";
            student.classeSt = "classe";
            mydb.Students.Add(student);
            mydb.SaveChanges();
            return View();
        }
        public ActionResult deleteStudent(int id)
        {
            Student student = new Student();
            student = (from obj in mydb.Students where obj.IdSt == id select obj).FirstOrDefault();
            mydb.Students.Remove(student);
            mydb.SaveChanges();
            return View();
        }
        public ActionResult updateStudent(int id)
        {
            Student student = new Student();
            student = (from obj in mydb.Students where obj.IdSt == id select obj).FirstOrDefault();
            student.nameSt = "name1";
            student.emailSt = "email1";
            student.phoneSt = "phone1";
            student.classeSt = "classe1";
            mydb.SaveChanges();
            return View();
        }
    }
}