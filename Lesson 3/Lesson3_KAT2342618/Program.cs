using System;

// Katlyn Quinn
// kat2342618
// CIS262DA 10549

namespace Lesson3_KAT2342618
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Person person = new Person();
            person.FirstName = "Katlyn";
            person.LastName = "Quinn";
            person.SetName();
            person.AmountDue = 162;
            person.InvoiceDate = DateTime.Now;

            Business business = new Business();
            business.BusinessName = "AAA";
            business.SetName();
            business.AmountDue = 350;
            business.BusinessAddress = "123 Test Rd., Phoenix AZ 12345";
            business.InvoiceDate = DateTime.Now;

            Console.WriteLine( "Name:" + person.Name + " AmountDue:$" + person.AmountDue + " Due:" + person.CalculateDueDate().ToString( "MM/dd/yyyy" ) );
            person.Pay();
            Console.WriteLine( person.Name + " Account Paid. Amount Due:$ " + person.AmountDue );
            Console.WriteLine( "Name:" + business.Name + " AmountDue:$" + business.AmountDue + " Due:" + business.CalculateDueDate().ToString( "MM/dd/yyyy" ) );
            business.Pay();
            Console.WriteLine( business.Name + " Account Paid. Amount Due:$ " + business.AmountDue );

        }
    }
}
