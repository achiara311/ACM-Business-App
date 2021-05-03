using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }//defines whether the object represents a new entity such as a new customer
        public bool IsValid => Validate(); //method is set in getter

        public abstract bool Validate();
       
    }
}
