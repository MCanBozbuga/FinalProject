﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç.
    public interface IResult
    {
        bool Success { get; } //get = sadece okuabilir. set= yazmak için
        string Message { get; }
    }
}
