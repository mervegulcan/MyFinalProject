using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    
    //temel voidler için başlangıç,işlem sonucu ve kullanıcıyı bilgilendirme mesajı
    //get: sadece okunabilir, bişeyi return eder
    //set: yazmak için bunlar properties özellikleridir
    public interface IResult
    {

        bool Success { get;  }// giriş true /false ona bakacağız
        string Message { get; } //kullanıcıya bilgilendirme mesajı 
    }
}
