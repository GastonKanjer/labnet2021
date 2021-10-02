using LabNet.TP4.Data;
using LabNet.TP4.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet.TP4.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<EmployeesDto, int>
    {
        public List<EmployeesDto> GetAll()
        {
            var employees = (from e in context.Employees
                            select new EmployeesDto
                            {
                                EmployeeID = e.EmployeeID,
                                LastName = e.LastName,
                                FirstName = e.FirstName

                            }).ToList();
            
            return employees;
        }

        public EmployeesDto GetOne(int id)
        {
            Employees emp = context.Employees.Find(id);
            EmployeesDto employee = new EmployeesDto
            {
                EmployeeID = emp.EmployeeID,
                LastName = emp.LastName,
                FirstName = emp.FirstName
            };

            return employee;
        }


        public void Add(EmployeesDto newEmployee)
        {
            Employees employee = new Employees
            {
                EmployeeID = newEmployee.EmployeeID,
                LastName = newEmployee.LastName,
                FirstName = newEmployee.FirstName
            };

            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shipperToDelete = context.Shippers.SingleOrDefault(s => s.ShipperID == id);

            context.Shippers.Remove(shipperToDelete);
            context.SaveChanges();
        }


        public void Update(EmployeesDto employee)
        {
            var employeeUpdate = context.Employees.Find(employee.EmployeeID);

            employeeUpdate.LastName = employee.LastName;
            employeeUpdate.FirstName = employee.FirstName;

            context.SaveChanges();
        }


    }
}
