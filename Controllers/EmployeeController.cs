using AutoMapper;
using AutomapperASPNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AutomapperASPNetCore.Controllers
{
    public class EmployeeController: Controller
    {
        private readonly IMapper _mapper;
        public EmployeeController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var employeesVM = new List<EmployeeVM>();
            return View(employeesVM);
        }

        public IActionResult Create()
        {
            var employeeVM = new EmployeeVM();
            return View(employeeVM);
        }

        [HttpPost]
        public Employee Post(EmployeeVM employeeVM)
        {
            Employee employee = new Employee();
            employee = _mapper.Map<EmployeeVM, Employee>(employeeVM);
            return employee;
        }
    }
}
