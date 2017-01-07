using Grpc.Core;
using System;
using System.ComponentModel;
using System.Threading;

namespace AdminDesk_Server
{
    class Program
    {
        const int Port = 50051;

        public static void Main(string[] args)
        {
            //BackgroundWorker worker = new BackgroundWorker();

            var hostname = "localhost"; // "trymeadmintool.apphb.com";
            //var strPort = Environment.GetEnvironmentVariable("PORT");
            //var port = Convert.ToInt32(strPort);

            var serverPort = new ServerPort(hostname, Port, ServerCredentials.Insecure);

            Server server = new Server
            {
                Services = { Admindesk.AdminDesk.BindService(new AdminDeskServer()) },
                Ports = { serverPort }
            };
            server.Start();

            Console.WriteLine("AdminDesk server listening on host: {0} & port: {1}", serverPort.Host, serverPort.Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            //TimeSpan interval = new TimeSpan(0, 20, 0); // 20 minutes
            //Console.WriteLine("SERVER WILL BE ALIVE 20 MINUTES.");
            //Thread.Sleep(interval);
            //Console.WriteLine("SERVER SHUT DOWN.");

            server.ShutdownAsync().Wait();
        }
    }
}
