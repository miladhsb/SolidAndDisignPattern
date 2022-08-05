using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DesignPattern.Adapter
{
    public class EmailSenderThirdParty
    {
        public void SendEmail(string email)
        {
            Console.WriteLine( $"Send Email {email}" );
        }
    }
}
