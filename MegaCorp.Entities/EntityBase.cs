using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCorp.Entities
{
    public abstract class EntityBase: IPersistable
    {
        protected readonly int id;

        public EntityBase()
            : this(default) { }

        public EntityBase(int id)
        {
            if(id < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }
            this.id = id;
        }

        public int Id
            => id;
    }
}
