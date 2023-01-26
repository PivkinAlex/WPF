using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    public class Validator
    {
        public static string PassCheck(string pass)
        {
            if (pass.Length >= 7)
            { 
                return null; 
            }
            else
            {
                return "Error";
            }
        }
        public static string LoginCheck(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return null;
            }
            catch (FormatException)
            {
                return "Error";
            }
        }
    }
}
