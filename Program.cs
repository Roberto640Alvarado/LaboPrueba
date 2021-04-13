using System;

namespace Prueba.Class
{
    class Program
    {
        static void Main(string[] args)
        {
            IentitySite  entity = menuEntity();//creando variable de tipo de la interface

            bool continuar = true;
            do{
             Console.Write(menu());//Menu de las reservas etc
             int opcion = Convert.ToInt32(Console.ReadLine());
            
             switch(opcion)
             {
                case 1: entity.Reserve(); break;//Diferentes opciones
                case 2: entity.Deliver(); break;
                case 3: entity.Leave(); break;
                case 4: entity.Show(); break;
                case 5: continuar = false; break;
                default: Console.WriteLine("Opcion errónea!"); break;
            }
            }while(continuar);
            Console.WriteLine("\nFue un gusto servirle!");
        }
        static string menu()
        {
            return "\nBienvenido:\n" +
            "1) Reservar \n" +
            "2) Pedir Llaves del sitio reservado\n" +
            "3) Retirarse del sitio\n" +
            "4) Mostrar Reservas\n" +
            "5) Salir.\n" +
            "Opción elegida: ";
        }
        static IentitySite menuEntity()
        {
          Console.Write("\nWelcome to Gualterpillar Booking Services (GBS):\n" +
            "1) Seleccionar Hotel.\n" +
            "2) Seleccionar Cabaña.\n" +//Menu para seleccionar el sitio que quiere reservar
            "3) Seleccionar Choza.\n" +
            "Opción elegida: ");
          int option = Convert.ToInt32(Console.ReadLine());
        
          if(option == 1)
            return new Hotel("Hotel");
          if(option == 2)
            return new Cabin("Cabaña");
          else
            return new Hut("Choza");
        }
    }
}