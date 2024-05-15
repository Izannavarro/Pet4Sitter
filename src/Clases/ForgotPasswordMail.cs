using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piTest.MailServices
{
    public class ForgotPasswordMail:MasterMailServer
    {
        public ForgotPasswordMail()
        {
            //Ocultación de tokens:
            string jsonContent = System.IO.File.ReadAllText("token.JSON");

            // Parsear el contenido JSON
            JObject tokenData = JObject.Parse(jsonContent);

            
            senderMail = "pirojodam@gmail.com";
            // Extraer las propiedades del objeto JSON
            password = "tdty vtqs svke tugy";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
