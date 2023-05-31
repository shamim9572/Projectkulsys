using Microsoft.AspNetCore.Mvc;
using Projectkulsys.Models;

namespace Projectkulsys.Controllers
{
    public class StudentController : Controller
    {
        // Database of Instance

        private readonly StudentContext _Db;
        public StudentController(StudentContext Db)
        {
            _Db = Db;
        }
        [HttpGet]
        
        public IActionResult StudentList()
        {
            //return View(new List<Student>());
            List<Student> result = _Db.Student.ToList();
            
            return View(result);


            //<--------------------------------------------------->


            //try
            //{
            //    // if we are give the a single table data 
            //    //var stdList = _Db.student.toList();

            //    var stdList = from a in _Db.Student
            //                  join b in _Db.Department
            //                  on a.ID equals b.Id
            //                  into Dep
            //                  from b in Dep.DefaultIfEmpty()


            //                  select new Student
            //                  {
            //                      ID = a.ID,
            //                      FirstName = a.FirstName,
            //                      LastName = a.LastName,
            //                      Mobilenumber = a.Mobilenumber,
            //                      Discription = a.Discription,


            //                      Department = b == null ? "" : b.Department
            //                  };


            //    List<Student> resut = stdList.ToList();

            //    return View(stdList.ToList());
            //}

            //catch (Exception ex)
            //{
            //    return View();
            //}

            //<------------------------------------------------------------------------------------------------>

        }
        [HttpPost]
        public async Task<IActionResult> Create(Student obj)
        {

                try
                {

                    //if (ModelState.IsValid)
                   // {
                        if (obj.ID == 0)
                        {
                            _Db.Student.Add(obj);
                            await _Db.SaveChangesAsync();
                        }



                        return RedirectToAction("StudentList");

                   // }
                   // return View();
                }

                catch (Exception ex)
                {
                    return RedirectToAction("StudentList");
                }
            }          

        
        public IActionResult Create()
        {
            ViewBag.Departments = _Db.Department.ToList();
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddStudent(Student obj)
        {
            try
            
            {

                if (ModelState.IsValid)
                {
                    if (obj.ID == 0)
                    {
                        _Db.Student.Add(obj);
                        await _Db.SaveChangesAsync();
                    }



                    return RedirectToAction("StudentList");

                }
                return View();
            }

            catch (Exception ex)
            {
                return RedirectToAction("StudentList");
            }
        }



        public async Task<IActionResult> DeleteStd(int id)
        {
            try
            {
                var std = await _Db.Student.FindAsync(id);

                if (std != null)
                {
                    _Db.Student.Remove(std);
                    await _Db.SaveChangesAsync();
                }

                return RedirectToAction("StudentList");
            }
            catch (Exception ex)
            {
                return RedirectToAction("StudentList");
            }
        }
        private void loadDDL()
        {
            try
            {
                List<Deparment> depList = new List<Deparment>();
                depList = _Db.Department.ToList();

                depList.Insert(0, new Deparment { Id = 0, Department = "Please Select" });

                ViewBag.DepList = depList;

            }
            catch (Exception ex)
            {

            }
        }

    }
}
