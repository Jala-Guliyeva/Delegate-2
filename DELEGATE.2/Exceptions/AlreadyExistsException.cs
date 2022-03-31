using System;
using System.Collections.Generic;
using System.Text;

namespace DELEGATE._2.Exceptions
{
    public class AlreadyExistsException:Exception
    {
        public AlreadyExistsException(string message):base(message)
        {

        }
    }
}
