using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       //this: classın kendisidir
        public Result(bool success, string message):this(success) 
        {
            Message = message;
           
        }
        //constructor overloading
        public Result(bool success)
        {
            
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
