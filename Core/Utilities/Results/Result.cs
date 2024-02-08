using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        private bool v1;
        private string v2;

        public Result(bool success, string massage):this(success)//içerde mires this ile alınır
        {
            Message = massage;
            
           
        }
        public Result(bool success)//overlooding
        {
            
            Success = success;

        }


        public bool Success { get; }//get ama constructerde set edilebilir

        public string Message { get; }
    }
}
