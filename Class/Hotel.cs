using System;

namespace Prueba.Class
{
    public class Hotel : CustomerData , IentitySite  //heredando clases y la interface
    {
        public int room { get; set; }//atributos
        public int pay { get; set; }

        public Hotel(string name = "", int id= 0, int room = 0, int pay = 0)//constructor
        : base(name, id)
        {
            this.room = room;
            this.pay = pay;
        }  
        public void Reserve()//Metodo para reservar
        {
            Console.WriteLine("***Precio de la Habitacion $30***");
            Data();//Pedir datos al cliente
            Console.Write("Ingrese la cantidad de habitaciones a reservar: ");
            room = Int32.Parse(Console.ReadLine());

            Console.Write("\nDesea pagar con: \n" +//Pagando
            "1) Tarjeta de credito\n" +
            "2) Efectivo\n" +
            "Ingrese opcion: ");
            int option = Int32.Parse(Console.ReadLine());

            if(option==1)//Verificando la forma de pago
            {
            Console.Write("Ingrese el Numero de Tarjeta: ");
            pay = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Pago exitosamente ${room*30}");
            } 

            if(option==2)
              Console.WriteLine($"Cobrando los ${room*30} de la Habitacion del hotel...");

            else
             Console.WriteLine("Opcion Invalida");
        }

        public void Deliver()//Entregar la habitacion al clinte con las llaves
        {
            bool verify = true;
            Console.WriteLine("***VERIFICANDO LOS VALORES DE SU RESERVA***");
            Check(verify);//Verificando la reserva

            if(verify==true)
              Console.WriteLine("Entregando las llaves de la habitacion...");

            else
              Console.WriteLine("Datos erróneos");
        }

        public void Leave()//Cuando el cliente se retire
        {
            DeleteReservation();
        }

        public void Show()//Mostrar las reservaciones de los clientes
        {
            Console.WriteLine("\nMostrando las Reservaciones del Hotel");
            showReserva();//Mostrar los datos de los clientes
        }
    }
}