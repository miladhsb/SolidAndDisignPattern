using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DesignPattern.Adapter
{
    public class ObjectAdapter : IMessanger
    {
        private readonly EmailSenderThirdParty emailSenderThirdParty;

        public ObjectAdapter(EmailSenderThirdParty emailSenderThirdParty)
        {
            this.emailSenderThirdParty = emailSenderThirdParty;
        }
        public void SendMessage(string message)
        {
            emailSenderThirdParty.SendEmail(message);
        }
    }
}
