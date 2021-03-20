using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {
                
        }
        public SuccessDataResult(): base(default,true)
        {

        }
        public SuccessDataResult(string message):base(default,false,message)
        {

        }
    }
}
