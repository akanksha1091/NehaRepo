using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels .Tcp ;
using System.Runtime.Remoting;

namespace RemotingServiceHost1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloRemotingServices.HelloRemotingService remotingservice = new HelloRemotingServices.HelloRemotingService();
            TcpChannel channel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(HelloRemotingServices.HelloRemotingService), "GetMessage", WellKnownObjectMode.Singleton);
            Console.WriteLine("Remoting service started at " + DateTime.Now);
            Console.ReadLine();
            

        }
    }
}
