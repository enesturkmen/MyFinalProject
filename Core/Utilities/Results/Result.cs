using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //getter read-only'dir ancak constructor'da set edilebilirler.
        public Result(bool isSuccess, string message):this(isSuccess)
        {
            Message = message;
        }
        //overloading yaptik
        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
