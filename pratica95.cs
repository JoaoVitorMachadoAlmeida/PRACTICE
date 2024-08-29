using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main()
    {
        try
        {


            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation details: " + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            DateTime now = DateTime.Now;

            reservation.UpdateDates(checkIn, checkOut);
            Console.WriteLine("Reservation details: " + reservation);
        }
        catch (DomainException e)
        {
            Console.WriteLine("Error in reservation: " + e.Message);
        }
    }
}

/************************************************************/
class Reservation
{
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Reservation()
    {
    }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
        if (checkOut <= checkIn)
        {
            throw new DomainException("Check-out date must be after check-in date.");
        }

        RoomNumber = roomNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public int Duration()
    {

        TimeSpan duration = CheckOut.Subtract(CheckIn);
        return (int)duration.TotalDays;
    }

    public void UpdateDates(DateTime checkIn, DateTime checkOut)
    {
        DateTime now = DateTime.Now;
        if (CheckIn < now || CheckOut < now)
        {
            throw new DomainException("Reservation dates for update must be future dates");
        }
        if (checkOut <= checkIn)
        {
            throw new DomainException("Check-out date must be after check-in date.");
        }

        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public override string ToString()
    {
        return "Room"
        + RoomNumber
        + ", check in: "
        + CheckIn.ToString("dd.MM.yyyy")
        + ", check out: "
        + CheckOut.ToString("dd.MM.yyyy")
        + ", "
        + Duration()
        + " nights";
    }
}
/******************************************************/
class DomainException : ApplicationException
{
    public DomainException(string message) : base(message)
    {
    }
}
