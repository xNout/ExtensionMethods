using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace ExtensionMethods
{
    public class MailService
    {
        public static bool IsValid(string emailaddress)
        {
            if (emailaddress == "")
                emailaddress = "d";

            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }

        }
    }
}
