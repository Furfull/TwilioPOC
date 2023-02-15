using Twilio.Rest.Verify.V2.Service;
using Twilio;

namespace TwilioPOC.services
{
    public class VerifyCode
    {
        public static void Execute(string code)
        {
            TwilioClient.Init(Autenticacao.accountSid, Autenticacao.authToken);

            var verificationCheck = VerificationCheckResource.Create(
                to: Autenticacao.toNumber,
                code: code,
                pathServiceSid: Autenticacao.pathServiceSid
            );

            Console.WriteLine(verificationCheck.Status);
        }
    }
}
