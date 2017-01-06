using Admindesk;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminDesk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            //var client = new Admindesk.AdminDesk.AdminDeskClient(channel);

            //var subjectsRequest = client.GetSubjects(new IdRequest());
            //Console.WriteLine("Number of subjects: " + subjectsRequest.Subjects.Count);

            //var classesRequest = client.GetClasses(new IdRequest());
            //Console.WriteLine("Number of classes: " + classesRequest.Classes.Count);

            //var testNamesRequest = client.GetTestNames(new IdRequest());
            //Console.WriteLine("Number of testNames: " + testNamesRequest.Themes.Count);

            //var testsRequest = client.GetTest(new IdRequest() { Id = "001" });
            //Console.WriteLine("Number of questions in the test: " + testsRequest.Questions.Count);

            //channel.ShutdownAsync().Wait();
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
        }
    }
}
