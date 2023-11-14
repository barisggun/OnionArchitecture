using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : this("Validation error occured")
        {
            //hiçbir parametre gelmiyorsa böyle bir hata oluşsun
            //message olarak bunu gönderecek 
        }

        public ValidationException(string Message) : base(Message)
        {
            //string mesaj geliyorsa biz onu base'e message olarak gönderelim
        }

        public ValidationException(Exception ex) : this(ex.Message)
        {
            
        }
    }
}
