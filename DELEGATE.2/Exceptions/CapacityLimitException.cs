using System;
using System.Collections.Generic;
using System.Text;

namespace DELEGATE._2.Exceptions
{
    internal class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base (message)
        {

        }
    }
}
