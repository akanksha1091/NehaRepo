using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;


namespace HelloRemoteingServiceClient
{
    public partial class Form1 : Form
    {
        IHelloRemotingSerice.IHelloReMotingService client;
        public Form1()
        {
            InitializeComponent();
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (IHelloRemotingSerice.IHelloReMotingService)Activator.GetObject(typeof(IHelloRemotingSerice.IHelloReMotingService), "tcp://localhost:8080/GetMessage");
        }

        

        private void GetMessage_Click(object sender, EventArgs e)
        {
            label1.Text = client.GetMessage(textBox1.Text);
        }
    }
}
