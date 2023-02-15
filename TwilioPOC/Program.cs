using Twilio.Rest.Taskrouter.V1.Workspace.TaskQueue;
using TwilioPOC.services;

namespace TwilioPOC
{
    class Program
    {
        static void Main()
        {
            SendCode.Execute();

            Console.WriteLine("DIGITE O CODIGO: ");
            var response = Console.ReadLine();

            VerifyCode.Execute(response);
        }
    }
}