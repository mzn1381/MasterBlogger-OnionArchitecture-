using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.Base
{
   public class BaseDomain
    {
        public long Id { get; protected set; }
        public bool IsDeleted { get;protected set; }
        public DateTime CreationDate { get; protected set; }
    }
}
