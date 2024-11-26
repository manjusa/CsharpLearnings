using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAndSortingEg
{
    internal class CustomerComparer : IComparer<Customer>
    {      

        public int Compare(Customer? x, Customer? y)
        {
            if (x == null && y == null) return 0; // Both are null, considered equal
            if (x == null) return -1; // Null is less than non-null
            if (y == null) return 1;  // Non-null is greater than null
            return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}
