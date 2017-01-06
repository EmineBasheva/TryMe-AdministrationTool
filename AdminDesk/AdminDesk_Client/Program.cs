using Admindesk;
using Grpc.Core;
using System;

namespace AdminDesk_Client
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Start AdminDesk_Client...");

            var hostname = "trymeadmintool.apphb.com"; // "127.0.0.1";

            Channel channel = new Channel(hostname + ":50051", ChannelCredentials.Insecure);

            var client = new Admindesk.AdminDesk.AdminDeskClient(channel);

            Console.WriteLine("Get items...");

            var subjectsRequest = client.GetSubjects(new IdRequest());
            Console.WriteLine("Number of subjects: " + subjectsRequest.Subjects.Count);

            var classesRequest = client.GetClasses(new IdRequest());
            Console.WriteLine("Number of classes: " + classesRequest.Classes.Count);

            var testNamesRequest = client.GetTestNames(new IdRequest());
            Console.WriteLine("Number of testNames: " + testNamesRequest.Themes.Count);

            var testsRequest = client.GetTest(new IdRequest() { Id = "001" });
            Console.WriteLine("Number of questions in the test: " + testsRequest.Questions.Count);

            channel.ShutdownAsync();//.Wait();
            //Console.WriteLine("Press any key to exit...");
            //Console.Read();
        }
    }
}
