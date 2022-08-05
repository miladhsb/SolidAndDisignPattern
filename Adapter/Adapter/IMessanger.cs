using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DesignPattern.Adapter
{
    public interface IMessanger
    {

        public void SendMessage(string message)
        {
            Console.WriteLine($"send  : {message}"); 
        }
    }
}
