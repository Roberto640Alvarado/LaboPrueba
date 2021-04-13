using System;
using System.Collections.Generic;//Utilizando libreria para la lista

namespace Prueba.Class
{
    public class CustomerData
    {
        public struct Client //Creando struct
        {
          public string name { get; set; }
          public int id { get; set; }
        }
        Client client = new Client(); //Creando variable de tipo struct
        public CustomerData (string name,int id)//Constructor
            {
                this.client.name = name;
                this.client.id = id;
            }
        List<Client> ListClient = new List<Client>();//Creando lista 

        public void Data() //Metodo para pedir datos al cliente al momento de reservar
        {
            Console.WriteLine("\n******REGISTRANDO LOS DATOS DEL CLIENTE******");
            Console.Write("Ingrese su nombre: ");
            client.name = Console.ReadLine();
            Console.Write("Ingrese el DUI: ");
            client.id = Int32.Parse(Console.ReadLine());
            ListClient.Add(client);
        }

        public void showReserva() //Metodo para mostrar las reservaciones
        {
            ListClient.ForEach(show =>
               Console.WriteLine($"[Nombre: {show.name} , DUI: {show.id}] "));
        }

        public bool Check(bool verify) //Metodo para verificar los datos del cliente
        {
            Console.Write("Ingrese su nombre: ");
            string nameC = Console.ReadLine();
            Console.Write("Ingrese su DUI: ");
            int dui = Int32.Parse(Console.ReadLine());
            verify = ListClient.Contains(new Client { name = nameC , id = dui });

            return verify;
        }
        public void DeleteReservation() //Metodo para Eliminar reservaciones de los clientes
        {
            bool verify = true;
            Console.WriteLine("***ELIMINAR SU RESERVACION***");
            Console.Write("\nDigite el Nombre del cliente a eliminar: ");
            string nameC = Console.ReadLine();
            Console.Write("Digite el DUI del cliente a eliminar: ");
            int dui = Int32.Parse(Console.ReadLine());
            verify = ListClient.Contains(new Client { name = nameC , id = dui });

            if(verify == true)
            {
                ListClient.Remove(new Client { name = nameC , id = dui });
                Console.WriteLine("Devolviendo las llaves...");
            }
            else
            {
                Console.WriteLine("Opcion No valida");
            }
        }

    }
}