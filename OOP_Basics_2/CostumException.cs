using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsDemo
{
    class CostumException : Exception
    {
        public override string Message => "Нещо много се счупи";
    }
}
