using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
            
        }
    }
}
