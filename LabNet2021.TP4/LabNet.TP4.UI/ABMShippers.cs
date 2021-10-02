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
    public class ABMShippers : ISubmenu
    {

        public void Consulta()
        {

            ShippersLogic shippersLogic = new ShippersLogic();
            foreach (ShippersDto shippers in shippersLogic.GetAll())
            {
                WriteLine($" {shippers.ShipperID} - {shippers.CompanyName} - {shippers.Phone}");
            }
            Console.ReadLine();
            Clear();
        }

        public void Agregar()
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            int addID;
            string nombreCompania, telefono;

            try
            {
                WriteLine("Ingrese un id nuevo");
                addID = int.Parse(Console.ReadLine());
                WriteLine("Ingrese nombre de la compañia nueva");
                nombreCompania = ReadLine();
                WriteLine("Ingrese telefono de la compañia");
                telefono = ReadLine();


                shippersLogic.Add(new ShippersDto
                {
                    ShipperID = addID,
                    CompanyName = nombreCompania,
                    Phone = telefono
                });

                WriteLine("Empleado agregado con exito!!");

            }

            catch (Exception)
            {

                WriteLine("Ingrese un dato valido");
            }

        }

        public void Eliminar()
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            try
            {
                WriteLine("Ingrese el id de la compania que desea eliminar");
                int id = int.Parse(Console.ReadLine());
                shippersLogic.Delete(id);

                WriteLine("Empleado eliminado con exito!!");

            }
            catch (Exception)
            {
                WriteLine("Ingrese un id valido");
            }

        }

        public void Modificar()
        {
            try
            {
                string nombreCompania, telefono;
                ShippersLogic shippersLogic = new ShippersLogic();

                WriteLine("Ingrese el id del transportista que desea modificar");
                int searchID = int.Parse(Console.ReadLine());
                WriteLine("Ingrese el nuevo nombre de la compañia");
                nombreCompania = ReadLine();
                WriteLine("Ingrese telefono  nuevo de la compañia");
                telefono = ReadLine();


                shippersLogic.Update(new ShippersDto
                {
                    ShipperID = searchID,
                    CompanyName = nombreCompania,
                    Phone = telefono
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
