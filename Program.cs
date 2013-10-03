using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication1
{
    class Program
    {
        public Hash table;

        public Program()
        {
            this.table = new Hash();
        }

        public void datospersona()
        {
            persona p = new persona();
            Console.WriteLine("\n\t Introduce el codigo(id)");
            p.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el nombre");
            p.nombre = Console.ReadLine();

            Console.WriteLine("Introduce el telefono");
            p.telefono = Console.ReadLine();

            Console.WriteLine("Introduce tel facebook");
            p.facebook = Console.ReadLine();
            this.table.acceshash().Add(p.id, p);
        }



        public void editpersona()
        {    int id;

        for (int rep = 1 ; rep <= 2 ; rep++ )
        {

            Console.WriteLine("\n\tCual id quiere editar? ");
            id = Convert.ToInt32(Console.ReadLine());

            persona persona = (persona)this.table.acceshash()[id];
            Console.WriteLine("Escriba el nuevo nombre : ");
            persona.nombre = Console.ReadLine();
            Console.WriteLine("Escriba el nuevo Telefono  : ");
            persona.telefono = Console.ReadLine();
            Console.WriteLine("Escriba el nuevo Facebook : ");
            persona.facebook = Console.ReadLine();
            this.table.acceshash()[id] = persona;
        }
        }

        public void borrarpersona() {

            int id;
            string opc;
            for (int rep = 1; rep <= 2; rep++)
            {

                Console.WriteLine("\t\n Cual id quieres Borrar? ");
                id = Convert.ToInt32(Console.ReadLine());

                persona persona = (persona)this.table.acceshash()[id];
                Console.WriteLine("Esta seguro que decea borrar los datos?(s -> si         n -> no)");
                 opc = Console.ReadLine();
                 if (opc == "s")
                 {
                     Console.WriteLine("\n\n Borrado con Exito");
                     this.table.acceshash().Remove(id);
                 }
                 else if (opc == "n") Console.WriteLine("\n\n DATO NO BORRADO ");
                 else
                 {
                     Console.WriteLine("Tecla no valida ");

                 }
            }
        }




        static void Main(string[] args)

        {
            Program programa = new Program();
            Console.WriteLine("\t\t     ----------MaYeL.Corp------------");
            Console.WriteLine("\t----------Introduccion de Datos personales------------");
            
            for (int cont = 0; cont < 4; cont++)
            {   
                programa.datospersona();
            }

                ICollection llaves = programa.table.acceshash().Keys;
                Console.Clear();

                Console.WriteLine("\t------------Informacion de Usuarios registrados-----------");
                foreach (int k in llaves)
                {
                   persona persona = (persona)programa.table.acceshash()[k];
                   Console.WriteLine("\n Id de usuarios: " + k + 
                                     "\n Nombre: " + persona.nombre + 
                                     "\n Telefono: " + persona.telefono + 
                                     "\n Facebook :" + persona.facebook);
                        }
            Console.WriteLine("\t------------Precione cualquier tecla para editar 2 usuarios-----------");
            Console.ReadKey();


                programa.editpersona();

                Console.WriteLine("\t------------Informacion de Usuarios Editada-----------");
                foreach (int k in llaves)
                {
                    persona persona = (persona)programa.table.acceshash()[k];
                    Console.WriteLine("\n Id de usuarios: " + k +
                                      "\n Nombre: " + persona.nombre +
                                      "\n Telefono: " + persona.telefono +
                                      "\n Facebook :" + persona.facebook);
                }

                Console.WriteLine("\t\t------------Precione cualquier tecla para Borrar 2 Usuarios-----------");
                Console.ReadKey();

                programa.borrarpersona();

                Console.WriteLine("\t\t------------Informacion de Usuarios Borrada-----------");
                foreach (int k in llaves)
                {
                    persona persona = (persona)programa.table.acceshash()[k];
                    Console.WriteLine("\n Id de usuarios: " + k +
                                      "\n Nombre: " + persona.nombre +
                                      "\n Telefono: " + persona.telefono +
                                      "\n Facebook :" + persona.facebook);
                }
                Console.WriteLine("\t\t------------Precione cualquier tecla para Finalizar el programa-----------");
                Console.ReadKey();
        }

    }

}
