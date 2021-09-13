using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



namespace TP2
{
    class Consola
    {
        static void Main(string[] args)
        {
           
             new Consola().Menu();
        }

        public void Menu()
        {
            int opcion;
            do
            {
                do
                {
                    
                    WriteLine("Ingrese la opcion");
                    WriteLine("1 - Dividir por cero");
                    WriteLine("2 - Dividir dos numeros");
                    WriteLine("3 - Mostrar excepcion");
                    WriteLine("4 - Mostrar otra excepcion xd");
                    WriteLine("5 - Salir");
                    
                    opcion = int.Parse(ReadLine());

                    Clear();

                } while (opcion < 1 && opcion > 5);

                switch (opcion)
                {
                    case 1:
                        DividirCero();
                        break;
                    case 2:
                        Division();
                        break;

                    case 3:
                        MuestraExcep();                       
                        break;
                   
                    case 4:
                        OtraExcep();
                        break;
                    case 5:
                        WriteLine("Gracias por usar el programa. Adios");
                        break;

                }

            } while (opcion != 5);

            ReadKey();
        }
        public void DividirCero()
        {
            int numero;

            WriteLine("Ingrese un numero");
            numero = int.Parse(ReadLine());

            try
            {
                int resultado = numero.Dividir();
            }
            catch (DivideByZeroException ex)
            {
                Clear();
                WriteLine("\nNo puede dividir por cero \n {0}\n", ex);
            }
            finally
            {
                WriteLine("\nOperacion realizada");
            }

            
        }

        public void Division()
        {
            int  divis;
            double resultado =0, divid;
            bool resul = true;

            try
            {
                WriteLine("Ingrese el dividendo");
                divid = int.Parse(ReadLine());
                WriteLine("Ingrese el divisor");
                divis = int.Parse(ReadLine());
                resultado = divid.Dividir(divis);
                
            }
            catch (DivideByZeroException ex)
            {
                Clear();
                WriteLine("\n           Usted ha dividido por 0 \n " +
                                        "INSENSATO, HA ALTERADO EL ORDEN NATURAL DE LAS COSAS\n\n{0}\n\n", ex);
                resul = false;
            }
            catch(FormatException e)
            {
                Clear();
                WriteLine("\n Ingreso una letra o no ingreso nada {0} \n",e);
            }
            /*En este caso no se como hacer para que entre en el catch cuando divido por 0, si declaro las variables como int entra
            pero hace mal la operacion. Si las declaro como float / double hace bien la division, pero no entre en el catch
             En el metodo "DivisionPorCero" en UnitTest se puede observar que el test no funciona al no tirar la excepcion */

            WriteLine("El resultado es {0}",resultado);

            string devolver = (resul) ? "Ha sido exitosa" : "no ha sido exitosa";
            WriteLine($" Resultado {devolver}");
        }

        public void MuestraExcep()
        {
            try
            {
                Logic.Excepcion(null, 1);
            }
            catch (InvalidOperationException ex)
            {

                WriteLine("\nUna de las variables posee valor nulo\n");
                WriteLine("\n{0}\n", ex.Message);

            }
        }

        public void OtraExcep()
        {
            try
            {
                throw new CustomException();
            }
            catch (Exception ex)
            {
                WriteLine($"La Excepcion '{ex.Message}' personalizada ha sido capturada exitosamente");
                
            }
        }
    }



}
