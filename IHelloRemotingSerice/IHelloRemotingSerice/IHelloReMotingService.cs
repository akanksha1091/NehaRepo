using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHelloRemotingSerice
{
    public interface IHelloReMotingService
    {
       string GetMessage(string name);
       
    }
}
