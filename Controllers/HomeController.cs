using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;
using System.Web.Optimization;

namespace ITcompany.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ITCompanyEntities4 db = new ITCompanyEntities4();
        public ActionResult Index()
        {
            List<Events_General_Online> lst = db.Events_General_Online.Where(x=>x.EventCategory=="Online").ToList<Events_General_Online>();
            return View(lst);
            
        }
        public ActionResult Employee_Event()
        {
            List<Events_General_Online> lst = db.Events_General_Online.Where(x=>x.EventCategory == "Employee Specific").ToList<Events_General_Online>();
            return View(lst);

        }
        public ActionResult register(int? EventID)
        {
            
            Events_Reg_General_Online obj = new Events_Reg_General_Online();
            obj.EventId = EventID;
            return View(obj);
            }
        [HttpPost]
        public ActionResult register(int? EventID,[Bind(Include ="FirstName,LastName,EventId,MobileNo,Email")] Events_Reg_General_Online obj)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    db.Events_Reg_General_Online.Add(obj);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                    
                }

            }
            catch (Exception)
            {

                throw;
            }
            return View(obj);
        }
        public ActionResult register_employee(int? EventID)
        {
            Employee_Events_Registration obj = new Employee_Events_Registration();
            obj.Event_ID = EventID;
            List<Employee_Data> list = db.Employee_Data.ToList();
            ViewBag.EmployeeList = new SelectList(list, "Emp_ID", "Emp_ID");
            return View(obj);
        }
        [HttpPost]
        public ActionResult register_employee(int? EventID,Employee_Events_Registration obj)
        {
            try
            {
                List<Employee_Data> list = db.Employee_Data.ToList();
                ViewBag.EmployeeList = new SelectList(list, "Emp_ID", "Emp_ID");
                if (ModelState.IsValid)
                {
                    db.Employee_Events_Registration.Add(obj);
                    db.SaveChanges();
                    return RedirectToAction("Employee_Event");
                }
               
            }
            catch (Exception)
            {
                
                    throw;
                }
            return View(obj);
        }


    }
}