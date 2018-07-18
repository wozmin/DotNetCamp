using System;
using System.Collections.Generic;
using System.Text;

namespace GamesServer.BLL.Exceptions
{
    class ValidationException:Exception
    {
        public string Property { get; set; }

        public ValidationException(string msg, string property):base(msg)
        {
            Property = property;
        }
    }
}
