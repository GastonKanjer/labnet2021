using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LabNet2021.TP1
{
    public class Consola
    {
        public static void Main(string[] args)
        {
            

            new Consola().Menu();

        }

        public void Menu()
        {
            List<Omnibus> colectivo = new List<Omnibus>
            {

            };
            
            List<Taxi> tacho = new List<Taxi>
            {

            };

            int opcion;
            do
            {
                do
                {
                    WriteLine("Ingrese la opcion");
                    WriteLine("1 - Cargar Omnibus");
                    WriteLine("2 - CargarTaxi");
                    WriteLine("3 - Mostrar Lista");
                    WriteLine("4 - Salir");

                    opcion = int.Parse(ReadLine());

                    Clear();

                } while (opcion < 1 && opcion > 4);

                switch (opcion)
                {
                    case 1:
                        CargarOmnibus(colectivo);
                        break;
                    case 2:
                        CargarTaxis(tacho);
                        break;

                    case 3:
                        Listado(colectivo, tacho);
                        break;

                    case 4:
                        WriteLine("Gracias por usar el programa. Adios");
                        break;

                }

            } while (opcion != 4);

            ReadKey();
        }
        public void CargarOmnibus(List<Omnibus> colectivo)
        {

           

            for (int i = 0; i < 5; i++)
            {
                colectivo.Add(new Omnibus(IngresarPasajeros()));
            }
            
            

        }
       
        public void CargarTaxis(List<Taxi> tacho)
        {


            for (int i = 0; i < 5; i++)
            {
                tacho.Add(new Taxi(IngresarPasajeros()));
            }



        }

        public int IngresarPasajeros()
        {
            int cantPasajeros = 0;
            Clear();
            WriteLine("Ingrese la cantidad de pasajeros");
            try
            {            
               cantPasajeros = int.Parse(ReadLine());
                
            }
            catch (Exception e)
            {
                
                WriteLine("Ingrese un numero valido", e.Message);
                
            }
           
            return cantPasajeros;
        }



        public void Listado(List<Omnibus> colectivo, List<Taxi> tacho)
        {
            Consola c = new Consola();
            Clear();

            WriteLine("Colectivos: ");
             foreach (Omnibus o in colectivo )
            {
                WriteLine(" {0} pasajeros", o.pasajeros);
            }

            WriteLine("Tachos: ");
            foreach (Taxi t in tacho)
            {
                WriteLine(" {0} pasajeros", t.pasajeros);
                
            }
        }
        
        
    }
}
