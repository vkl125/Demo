using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactCrudDemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactCrudDemo.Controllers
{
    public class EmployeeController : Controller
    {
        //private readonly ICalendarManager _icalendarManager;
        //public EmployeeController(ICalendarManager calendarManager)
        //{
        //    _icalendarManager = calendarManager;
        //}
        
        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable<TblEmployee> Index()
        {
            //var bas = _icalendarManager.GetEventAndSchedule(DateTime.Now, DateTime.Now.AddDays(30));
            //return objemployee.GetAllEmployees();
            return null;
        }

        [HttpPost]
        [Route("api/Employee/Create")]
        public int Create(TblEmployee employee)
        {
            //return objemployee.AddEmployee(employee);
            return 0;
        }

        [HttpGet]
        [Route("api/Employee/Details/{id}")]
        public TblEmployee Details(int id)
        {
            //return objemployee.GetEmployeeData(id);
            return null;
        }

        [HttpPut]
        [Route("api/Employee/Edit")]
        public int Edit(TblEmployee employee)
        {
            //return objemployee.UpdateEmployee(employee);
            return 0;
        }

        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            //return objemployee.DeleteEmployee(id);
            return 0;
        }

        [HttpGet]
        [Route("api/Employee/GetCityList")]
        public IEnumerable<TblCities> Details()
        {
            //return objemployee.GetCities();
            return null;
        }
    }
}
