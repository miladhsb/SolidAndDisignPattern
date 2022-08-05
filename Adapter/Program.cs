using Adapter.DesignPattern.Adapter;
using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessanger messanger = new SmsMessage();

            messanger.SendMessage("hello");

            IMessanger messanger2=new InheritanceEmailAdapter();
            messanger2.SendMessage("hello");

            IMessanger messanger3 = new ObjectAdapter(new EmailSenderThirdParty());
            messanger2.SendMessage("hello");
        }
    }
}
