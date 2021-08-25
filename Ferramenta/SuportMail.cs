using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ferramenta
{
    class SuportMail:MailServer
    {
        
        public SuportMail()
        {
            senderMail = "anondate479@gmail.om";
            password = "93COmspirace";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();

        }
    }
}
