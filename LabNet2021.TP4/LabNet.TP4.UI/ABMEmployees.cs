using LabNet.TP4.Entitites;
using LabNet.TP4.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LabNet.TP4.UI
{
    class ABMEmployees : ISubmenu
    {
        public void Consulta()
        {
            EmployeesLogic employeesLogic = new EmployeesLogic();
            foreach (Employees employee in employeesLogic.GetAll())
            {
                WriteLine($" {employee.FirstName} - {employee.LastName}");
            }
            Console.ReadLine();
            Clear();
        }
       
        public void Agregar()
        {
            EmployeesLogic shippersLogic = new EmployeesLogic();
            int addID;
            string nombre, apellido;

            try
            {

                WriteLine("Ingrese un id nuevo");
                addID = int.Parse(Console.ReadLine());
                WriteLine("Ingrese nombre de la compañia nueva");
                nombre = ReadLine();
                WriteLine("Ingrese telefono de la compañia");
                apellido = ReadLine();
                WriteLine("Empleado agregado con exito!!");


                shippersLogic.Add(new Employees
                {
                    EmployeeID = addID,
                    FirstName = nombre,
                    LastName = apellido
                });
            }
            catch (Exception)
            {

                WriteLine("Ingrese un dato valido");
            }

        }

       
        public void Eliminar()
        {
            EmployeesLogic employeesLogic = new EmployeesLogic();
            try
            {
                WriteLine("Ingrese el id de la compania que desea eliminar");
                int id = int.Parse(Console.ReadLine());
                employeesLogic.Delete(id);

                WriteLine("Empleado eliminado con exito!!");
            }
            catch (Exception)
            {

                WriteLine("Ingrese un id valido");
            }
            
        }

       
        public void Modificar()
        {
            string nombre, apellido;
            EmployeesLogic employeesLogic = new EmployeesLogic();

            try
            {
                WriteLine("Ingrese el id de la compania que desea modificar");
                int searchID = int.Parse(Console.ReadLine());
                WriteLine("Ingrese nombre de la compañia nueva");
                nombre = ReadLine();
                WriteLine("Ingrese telefono de la compañia");
                apellido = ReadLine();
                
                
                employeesLogic.Update(new Employees
                {
                    EmployeeID = searchID,
                    FirstName = nombre,
                    LastName = apellido
                });

                WriteLine("Empleado modificado con exito!!");

            }
            catch (Exception)
            {
               WriteLine("Ingrese un dato valido");
            }

        }
    }
}
