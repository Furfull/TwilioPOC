using Twilio.Rest.Verify.V2.Service;
using Twilio;

namespace TwilioPOC.services
{
    public class SendCode
    {
        public static void Execute()
        {
            TwilioClient.Init(Autenticacao.accountSid, Autenticacao.authToken);

            var verification = VerificationResource.Create(
                to: Autenticacao.toNumber,
                channel: "call",
                pathServiceSid: Autenticacao.pathServiceSid
            );

            Console.WriteLine(verification.Status);
        }
    }
}
