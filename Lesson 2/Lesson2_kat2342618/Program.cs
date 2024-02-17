using System.Reflection;
// Katlyn Quinn
// kat2342618
// CIS262DA 10549

namespace Lesson2_kat2342618
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
            person.DueDate = new DateTime( 2024, 2, 24 );
            person.InvoiceDate = DateTime.Now;
            

            Business business = new Business();
            business.BusinessName = "AAA";
            business.SetName();
            business.AmountDue = 350;
            business.BusinessAddress = "123 Test Rd., Phoenix AZ 12345";
            business.DueDate = new DateTime(2024, 3, 15);

            Console.WriteLine( "Name:" + person.Name + " AmountDue:$" + person.AmountDue + " Due:" + person.DueDate.ToString( "MM/dd/yyyy" ) );
            Console.WriteLine( "Name:" + business.Name + " AmountDue:$" + business.AmountDue + " Due:" + business.DueDate.ToString( "MM/dd/yyyy" ) );

            
        }
    }
}
