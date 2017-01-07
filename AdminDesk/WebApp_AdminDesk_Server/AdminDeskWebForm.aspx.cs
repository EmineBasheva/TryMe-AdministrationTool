using AdminDesk_Server;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_AdminDesk_Server
{
    public partial class AdminDeskWebForm : System.Web.UI.Page
    {
        const int Port = 50051;
        Server server;

        protected void Page_Load(object sender, EventArgs e)
        {
            var hostname = "trymeadmintool.apphb.com"; // "localhost";

            var serverPort = new ServerPort(hostname, Port, ServerCredentials.Insecure);

            server = new Server
            {
                Services = { Admindesk.AdminDesk.BindService(new AdminDeskServer()) },
                Ports = { serverPort }
            };
            server.Start();
            
            Console.WriteLine("AdminDesk server started."); //listening on port: " + Port);
            Console.WriteLine("Host: {0}; Port: {1}", serverPort.Host, serverPort.Port);
            //Console.WriteLine("Press any key to stop the server...");
            //Console.Read();

            //server.ShutdownAsync().Wait();
        }
        
    }
}