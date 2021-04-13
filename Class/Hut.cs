using System;

namespace Prueba.Class
{
    public class Hut : CustomerData , IentitySite //heredando clases y la interface
    {
        public int hub { get; set; } // atributos
        public int pay { get; set; }
    
        public Hut(string name = "", int id= 0, int hub = 0, int pay = 0)//Constructor
        : base(name, id)
        {
            this.hub = hub;
            this.pay = pay;
        } 
        public void Reserve()// Reservando la choza
        {
            Console.WriteLine("***Precio de la Choza $50***");
            Data(); //Pedir datos del cliente
            Console.Write("Ingrese la cantidad de Chozas a reservar: ");
            hub = Int32.Parse(Console.ReadLine());

            Console.Write("\nDesea pagar con: \n" + //Pagando
            "1) Tarjeta de credito\n" +
            "2) Efectivo\n" +
            "Ingrese opcion: ");
            int option = Int32.Parse(Console.ReadLine());

            if(option==1) //Verificar la forma de pago
            {
            Console.Write("Ingrese el Numero de Tarjeta: ");
            pay = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Pago exitosamente ${hub*50}");
            } 

            if(option==2)
              Console.WriteLine($"Cobrando los ${hub*50} de la Choza...");
            else
             Console.WriteLine("Opcion Invalida");
        }
        public void Deliver() //Entregando la choza con sus llaves u otros materiales
        {
            bool verify = true;
            Console.WriteLine("***VERIFICANDO LOS VALORES DE SU RESERVA***");
            Check(verify); //Verificando la reservacion

            if(verify==true)
              Console.WriteLine("Entregando las llaves de la choza y un poco de madera y algunos aceites aromáticos...");
            else
              Console.WriteLine("Datos erróneos");
        }

        public void Leave()//Eliminando reservacion del cliente
        {
            DeleteReservation(); //Metodo para eliminar reservacion
        }

        public void Show() //Mostrando los valores de las reservaciones de las chozas
        {
            Console.WriteLine("\nMostrando las Reservaciones de la Choza");
            showReserva();//Metodo para mostrar los valores
        }
    }
}