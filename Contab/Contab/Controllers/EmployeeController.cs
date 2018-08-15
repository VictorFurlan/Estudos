using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contab.Models;
using Contab.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Contab.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();
        Gender objgender = new Gender();

        List<Employee> lstemployee = new List<Employee>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new MyViewModel {
                employee = new Employee(),
                departments = new Departament(),
                gender = new Gender(),
                profession = new Profession(),
                lstemployee = objemployee.GetAllEmployees().ToList(),
            };

            return View(model);
        }

        // GET: Employee/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Employee employee = objemployee.GetEmployeeData(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        public IActionResult Create()
        {
            ViewBag.Depart = new SelectList
                (
                    new Departament().GetAllDepartaments(),
                    "DepartamentId",
                    "DepartName"
                );

            ViewBag.Prof = new SelectList
                (
                    new Profession().GetAllProfessions(),
                    "ProfessionId",
                    "ProfName"
                );

            var model = new MyViewModel
            {
                employee = new Employee(),
                departments = new Departament(),
                gender = new Gender(),
                profession = new Profession(),
                lstemployee = objemployee.GetAllEmployees().ToList(),
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Create([Bind] MyViewModel employee)
        {
            if (ModelState.IsValid)
            {
                objemployee.AddEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Employee employee = objemployee.GetEmployeeData(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind]Employee employee)
        {
            if (id != employee.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                objemployee.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employee/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Employee employee = objemployee.GetEmployeeData(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            objemployee.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

    }
}