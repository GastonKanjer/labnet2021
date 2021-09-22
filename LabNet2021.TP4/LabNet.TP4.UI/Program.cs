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
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Menu();
        }


        public void Menu()
        {
            int op =0;
            WriteLine("\nBienvenido Usuario, a continuacion, seleccione:\n");

            do
            {
                try
                {
                    do
                    {
                        WriteLine("1 - Empleado");
                        WriteLine("2 - Transportista");
                        WriteLine("3 - Salir");
                        WriteLine("\n Ingrese una opcion (1-3):");

                         op = int.Parse(Console.ReadLine());

                    } while (op < 1 && op > 3);

                    Clear();

                    switch (op)
                    {
                        case 1:
                            ABMEmployees abme = new ABMEmployees();
                            SubmenuEmpleados(abme);
                            break;
                        case 2:
                            ABMShippers abms = new ABMShippers();
                            SubmenuTranspor(abms);
                            break;
                        case 3:
                            break;

                    }
                }
                catch (FormatException)
                {

                    WriteLine("Ingrese un numero valido");
                    ReadLine();
                }


            } while (op != 3);

        } 
                   
        public void SubmenuEmpleados(ABMEmployees abme)
        {

            int opc =0;

            WriteLine("Ingrese la opcion deseada: ");

            do
            {
                try
                {

                    do

                    {

                        WriteLine("1– Consulta");

                        WriteLine("2– Agregar");

                        WriteLine("3- Modificar");

                        WriteLine("4- Eliminar");

                        WriteLine("5- Volver al menu");

                        WriteLine("\n Ingrese una opcion (1-5):");


                        opc = int.Parse(Console.ReadLine());


                        if (opc < 1 && opc > 5)

                        {

                            WriteLine("\n               !!\nLa opcion ingresada no es valida\n(presione Enter para continuar)");

                            ReadLine();

                        }


                        Clear();


                    } while (opc < 1 && opc > 5);


                    switch (opc)

                    {

                        case 1:

                            abme.Consulta();

                            break;

                        case 2:

                            abme.Agregar();

                            break;

                        case 3:

                            abme.Modificar();

                            break;

                        case 4:

                            abme.Eliminar();

                            break;

                        case 5:

                            break;
                    }
                }
                catch (FormatException)
                {

                    WriteLine("Ingrese un numero valido");
                    ReadLine();
                }
            } while (opc != 5);

            ReadKey();

        }
        public void SubmenuTranspor(ABMShippers abms)
        {

            int opc = 0;

            WriteLine("Ingrese la opcion deseada: ");

            do
            {
                try
                {

                    do

                    {

                        WriteLine("1– Consulta");

                        WriteLine("2– Agregar");

                        WriteLine("3- Modificar");

                        WriteLine("4- Eliminar");

                        WriteLine("5- Volver al menu");

                        WriteLine("\n Ingrese una opcion (1-5):");


                        opc = int.Parse(Console.ReadLine());


                        if (opc < 1 && opc > 5)

                        {

                            WriteLine("\n               !!\nLa opcion ingresada no es valida\n(presione Enter para continuar)");

                            ReadLine();

                        }


                        Clear();


                    } while (opc < 1 && opc > 5);


                    switch (opc)

                    {

                        case 1:

                            abms.Consulta();

                            break;

                        case 2:

                            abms.Agregar();

                            break;

                        case 3:

                            abms.Modificar();

                            break;

                        case 4:

                            abms.Eliminar();

                            break;

                        case 5:

                            break;
                    }
                }
                catch (FormatException)
                {

                    WriteLine("Ingrese un numero valido");
                    ReadLine();
                }
            } while (opc != 5);

            ReadKey();

        }
    }
}
