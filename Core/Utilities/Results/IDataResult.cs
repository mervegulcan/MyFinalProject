using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //hangi tipi döndüreceğini söyle 
    public interface IDataResult<T>:IResult
    {

        T Data { get; }
    }
}
