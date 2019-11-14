using MvcBasic_clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_clone.Controllers
{
    public class EmployeesController : Controller
    {

        private InfoContext db = new InfoContext();

        // GET: Employees
        public ActionResult Index()
        {
            var emps = db.Employees.ToList();
            return View(emps);
        }

        public ActionResult EmploeeList()
        {
            List<Employees> employees = new List<Employees>
            {
                new Employees { Id = 10001, Name = "David", Phone = "0933-123-456" , Email = "david@gmail.com" },
                new Employees { Id = 10002, Name = "Mary",  Phone = "0933-321-456" , Email = "mary@gmail.com"  },
                new Employees { Id = 10003, Name = "John",  Phone = "0933-231-456" , Email = "john@gmail.com"  },
                new Employees { Id = 10004, Name = "Cindy", Phone = "0933-456-456" , Email = "cindy@gmail.com" },
                new Employees { Id = 10005, Name = "Rose",  Phone = "0933-666-456" , Email = "rose@gmail.com"  }
            };
            return View(employees);
        }
    }
}