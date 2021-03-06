using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTenStore.Models
{
    public class Response
    {
        public Response(int status, string message)
        {
            this.status = status;
            this.message = message;
        }

        public int status { get; set; }
        public string message { get; set; }        
    }
}
