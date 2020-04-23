using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifyHourOfPabx
{
    public class Server
    {
        public String serverName { get; set; }
        public DateTime serverDate { get; set; }
        public DateTime localDate { get; set; }
        public TimeSpan diffDate { get; set; }
        public String message { get; set; }
        /*
        Server(string serverName, DateTime serverDate, DateTime localDate, TimeSpan diffDate)
        {
            this.serverName = serverName;
            this.serverDate = serverDate;
            this.localDate = localDate;
            this.diffDate = diffDate;
        }*/
    }
}
