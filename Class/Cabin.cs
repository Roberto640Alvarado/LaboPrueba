using System;

namespace Prueba.Class
{
    public class Cabin : CustomerData , IentitySite  //heredando clases y la interface
    {
        public int cabin { get; set; }//atributos
        public int pay { get; set; }
        public Cabin(string name = "", int id= 0, int cabin = 0, int pay = 0)//Constructor
        : base(name, id)
        {
            this.cabin = cabin;
            this.pay = pay;
        } 
        public void Reserve()//Reservando la cabaña
        {
            Console.WriteLine("***Precio de la Cabaña $40***");
            Data();//Pedir datos al cliente
            Console.Write("Ingrese la cantidad de Cabañas a reservar: ");
            cabin = Int32.Parse(Console.ReadLine());

            Console.Write("\nDesea pagar con: \n" +//pagando
            "1) Tarjeta de credito\n" +
            "2) Efectivo\n" +
            "Ingrese opcion: ");
            int option = Int32.Parse(Console.ReadLine());

            if(option==1)//Verificando la forma de pago
            {
            Console.Write("Ingrese el Numero de Tarjeta: ");
            pay = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Pago exitosamente ${cabin*40}");
            } 

            if(option==2)
              Console.WriteLine($"Cobrando los ${cabin*40} de la reserva de la Cabañas...");
            else
             Console.WriteLine("Opcion Invalida");
        }
        public void Deliver() //Cuando se le entregue las llaves de la cabaña
        {
            bool verify = true;
            Console.WriteLine("***VERIFICANDO LOS VALORES DE SU RESERVA***");
            Check(verify); //Verificando las reservaciones de cabañas

            if(verify==true)
              Console.WriteLine("Entregando las llaves y leña para la chimenea...");
            else
              Console.WriteLine("Datos erróneos");
        }

        public void Leave() //Cuando el cliente decida retirarse
        {
            DeleteReservation();//Eliminando reservacion   
        }

        public void Show() //Mostrando las reservaciones de las cabañas
        {
            Console.WriteLine("\nMostrando las Reservaciones de la Cabaña");
            showReserva(); //Mostrando los datos de los clientes
        }
    }
}