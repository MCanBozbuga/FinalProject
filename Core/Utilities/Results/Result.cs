﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //constrauctor
        public Result(bool success, string message):this(success)
        {
            Message = message;
          
        }
        public Result(bool success) //Sadece true/false
        {
            
            Success = success;   
        }

        public bool Success { get; }

        public string Message { get; }

    }
}
