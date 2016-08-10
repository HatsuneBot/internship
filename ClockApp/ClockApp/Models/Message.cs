using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClockApp.Controllers
{
    public class Message
    {
        public delegate void Container(int time);

        public event Container onSleep;

        public string NewMessage (int time, string message)
        {
            onSleep(time);
            string newMessage = "Прошло " + time + " секунд. " + message;
            return newMessage;
        }
    }
    
}