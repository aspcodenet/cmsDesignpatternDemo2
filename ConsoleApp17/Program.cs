using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    interface IMessageSender
    {
        void SendMessage(string message);
    }

    class SmsMessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            throw new NotImplementedException();
        }
    }

    class EmailMessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            throw new NotImplementedException();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender messageSender = new EmailMessageSender();
            //..
            //..
            //if(sdadasadsa>)
            messageSender.SendMessage("Hej hej");
        }
    }
}
