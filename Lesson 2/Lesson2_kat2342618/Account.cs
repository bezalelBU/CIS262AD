using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Katlyn Quinn
// kat2342618
// CIS262DA 10549

namespace Lesson2_kat2342618
{
    // Base Class
    public abstract class Account
    {
        public abstract string Name { get; set; }
        public abstract DateTime DueDate { get; set; }
        public abstract decimal AmountDue { get; set; }

        public virtual void SetName(){ }
        

    }

    // Person class
    public class Person : Account
    {
        public override string Name { get; set; }
        public override DateTime DueDate { get; set; }
        public override decimal AmountDue { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime InvoiceDate { get; set; }

        public override void SetName()
        {
            //base.SetName();
            Name = FirstName + " " + LastName;
        }

    }

    // Business class
    public class Business : Account
    {
        public override string Name { get; set; }
        public override DateTime DueDate { get; set; }
        public override decimal AmountDue { get; set; }
        public string BusinessName { get; set; }
        public string BusinessAddress { get; set; }

        public override void SetName()
        {
            Name = BusinessName;
        }

    }
}
