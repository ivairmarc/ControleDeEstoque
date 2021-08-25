using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DALSuportMail:DALMailServercs
    {
        
        public DALSuportMail()
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
