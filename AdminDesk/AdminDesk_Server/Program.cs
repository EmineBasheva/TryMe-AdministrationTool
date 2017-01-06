﻿using Grpc.Core;
using System;
using System.Threading;

namespace AdminDesk_Server
{
    class Program
    {
        const int Port = 50051;

        public static void Main(string[] args)
        {
            var hostname = "localhost";
            var strPort = Environment.GetEnvironmentVariable("PORT");
            var port = Convert.ToInt32(strPort);

            Server server = new Server
            {
                Services = { Admindesk.AdminDesk.BindService(new AdminDeskServer()) },
                Ports = { new ServerPort(hostname, port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("AdminDesk server listening on port: " + server.Ports.GetEnumerator().Current.Port);
            //Console.WriteLine("Press any key to stop the server...");
            //Console.Read();

            TimeSpan interval = new TimeSpan(0, 20, 0); // 20 minutes
            Console.WriteLine("SERVER WILL BE ALIVE 20 MINUTES.");
            Thread.Sleep(interval);
            Console.WriteLine("SERVER SHUT DOWN.");

            server.ShutdownAsync().Wait();
        }
    }
}
