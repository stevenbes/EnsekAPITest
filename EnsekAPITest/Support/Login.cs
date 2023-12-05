using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsekAPITest.Support
{
    public class Login
    {
        public string username { get; set; }
        public string password { get; set; }
    }


    public class loginSuccess
    {
        public string access_token { get; set; }
        public string message { get; set; }
    }



    
}
