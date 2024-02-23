using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Katlyn Quinn
// kat2342618
// CIS262DA 10549

namespace Lesson3_KAT2342618
{
    public abstract class Account
    {
        public abstract string Name { get; set; }

        //Remove DueDate as indicated in the instructions
        //public abstract DateTime DueDate { get; set; }
        public abstract DateTime InvoiceDate { get; set; }
        public abstract decimal AmountDue { get; set; }

        public virtual void SetName() { }
        public virtual DateTime CalculateDueDate() { return InvoiceDate; }


    }

    // Person class
    public class Person : Account, IPayMyBill
    {
        public override string Name { get; set; }
        public override DateTime InvoiceDate { get; set; }
        public override decimal AmountDue { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override void SetName()
        {
            Name = FirstName + " " + LastName;
        }

        public override DateTime CalculateDueDate() {
            DateTime DueDate = InvoiceDate.AddDays( 30 );
            return DueDate;
        }
        public void Pay() { AmountDue = 0; }

}

    // Business class
    public class Business : Account, IPayMyBill
    {
        public override string Name { get; set; }
        public override DateTime InvoiceDate { get; set; }
        public override decimal AmountDue { get; set; }
        public string BusinessName { get; set; }
        public string BusinessAddress { get; set; }

        public override void SetName()
        {
            Name = BusinessName;
        }

        public override DateTime CalculateDueDate() {
            DateTime DueDate = InvoiceDate.AddDays( 60 );
            return DueDate;
        }
        public void Pay() { AmountDue = 0; }
    }
}
