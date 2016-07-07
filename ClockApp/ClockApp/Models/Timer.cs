using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace ClockApp.Controllers
{
    public class Timer
    {
        public void Sleep(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }
    }
}
