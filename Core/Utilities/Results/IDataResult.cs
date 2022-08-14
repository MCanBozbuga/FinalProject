using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Hangi tipi döndüreceğini bana Söyle = public interface IDataResult<T>  // <T>
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
