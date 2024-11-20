using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1.Program.Exceptions
{
    class IncorrectNumberOfIngredientsException : Exception
    {


        private const long serialVersionUID = 1L;

        public IncorrectNumberOfIngredientsException()
        {
        }

        public IncorrectNumberOfIngredientsException(String message, Exception cause) : base(message, cause)
        {

        }

        public IncorrectNumberOfIngredientsException(String message) : base(message)
        {

        }

    }
}
