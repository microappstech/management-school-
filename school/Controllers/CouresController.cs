using school.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace school.Controllers
{
    public class CouresController : Controller
    {
        // GET: Coures

        Db mydb = new Db();
        public ActionResult getCourses()
        {
                List<Course> courses = new List<Course>();
                courses = (from obj in mydb.Courses select obj).ToList();
                return View(courses);
        }
        public ActionResult detailCourse(int id)
        {
            Course course = new Course();
            course = (from obj in mydb.Courses where obj.Id==id select obj).FirstOrDefault();
            return View(course);  
        }
        [HttpGet]
        public ActionResult addCourse()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addCourse(Course course)
        {
            

            HttpPostedFileBase file = Request.Files["image"];
            Dictionary<string, string> data = new Dictionary<string, string>();
            try
            {
                string[] extens = new string[] { ".jpg", ".png",".jfif" };
                List<string> errors = new List<string>();
                string imageFile = Guid.NewGuid()+Path.GetFileName(file.FileName);//the name with extens
                string exten = Path.GetExtension(file.FileName);
                string fullPath = Path.Combine(Server.MapPath("~/Content/images"),imageFile);
                if (extens.Contains(exten) & file.ContentLength > 0)
                {
                    file.SaveAs(fullPath);
                    course.image = imageFile;
                    mydb.Courses.Add(course);
                    mydb.SaveChanges();
                    Console.WriteLine("<script>alert('The course saved successfully')</script>");
                    return RedirectToAction("getCourses");
                }else
                {
                    errors.Add("You Should choose a image file");
                    return RedirectToAction("addCourse");
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            
            
            //return RedirectToAction("getCourses");
        }
        public ActionResult deleteCourse(int id)
        {
            Course course = new Course();
            course = (from obj in mydb.Courses where obj.Id == id select obj).FirstOrDefault();
            mydb.Courses.Remove(course);
            mydb.SaveChanges();
            return View();
        }
        public ActionResult updateCourse(int id)
        {
            Course course = new Course();
            course = (from obj in mydb.Courses where obj.Id == id select obj).FirstOrDefault();
            course.nameCo = "Test2";
            course.nbrH = 155;
            mydb.SaveChanges();
            return View();
        }
    }
}