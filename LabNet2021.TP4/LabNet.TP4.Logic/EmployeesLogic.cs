using LabNet.TP4.Data;
using LabNet.TP4.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet.TP4.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {
        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }
        public void Add(Employees newEmployee)
        {
            context.Employees.Add(newEmployee);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employeeToDelete = context.Employees.SingleOrDefault(s => s.EmployeeID == id);

            context.Employees.Remove(employeeToDelete);
            context.SaveChanges();
        }


        public void Update(Employees employee)
        {
            var employeeUpdate = context.Employees.Find(employee.EmployeeID);

            employeeUpdate.FirstName = employee.FirstName;
            employeeUpdate.LastName = employee.LastName;

            context.SaveChanges();
        }
    }
}
