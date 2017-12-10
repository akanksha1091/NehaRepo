using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloRemotingServices
{
    public class HelloRemotingService:MarshalByRefObject ,IHelloRemotingSerice.IHelloReMotingService
    {


        public string GetMessage(string name)
        {
            return "hello" + name;
        }
    }
}
