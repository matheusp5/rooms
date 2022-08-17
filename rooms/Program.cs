using System;
using rooms.Entities;

namespace rooms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número do quarto? ");
            int numberRoom = int.Parse(Console.ReadLine());
            Console.Write("Data de checkin? (dd/mm/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Data de checkout? (dd/mm/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());
            Reservation reservation = new Reservation(numberRoom, checkin, checkout);
            Console.WriteLine(reservation);

            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.Write("Insira a nova data de checkin? (dd/mm/yyyy): ");
            checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Insira a nova data de checkout? (dd/mm/yyyy): ");
            checkout = DateTime.Parse(Console.ReadLine());
            reservation.updateDate(checkin, checkout);
            Console.WriteLine(reservation);
        }
    }
}
