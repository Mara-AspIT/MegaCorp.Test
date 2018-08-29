using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCorp.Entities
{
    public class Person: EntityBase
    {
        public Person(string firstname, string lastname)
            : this(id: default, firstname, lastname) { }

        public Person(int id, string firstname, string lastname)
            : base(id)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public virtual string Firstname
        {
            get; set;
        }

        public virtual string Lastname
        {
            get; set;
        }
    }
}
