using System;

namespace CH6_Nullable_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //    bool? AreYouMajor = true;

            //    if (AreYouMajor == true)
            //    {
            //        Console.WriteLine("User is Major");
            //    }
            //    else if (AreYouMajor == false)
            //    {
            //        Console.WriteLine("user is not Major");
            //    }
            //    else
            //    {
            //        Console.WriteLine("User is Did not answer the question");
            //    }

            //Example2
            //int TicketOnSale = null;

            //int AvialableTicket;

            //if (TicketOnSale == null) 
            //{
            //    AvialableTicket = 0;
            //}
            //else
            //{
            //    AvialableTicket = (int)TicketOnSale;
            //}
            //Console.WriteLine("Avialable = {0}", AvialableTicket);


            //Example 3
            int? TicketOnSale = 100;

            int AvialableTicket = TicketOnSale ?? 0;

            Console.WriteLine("AvialableTicket = {0}", AvialableTicket);
        }
    }
}
