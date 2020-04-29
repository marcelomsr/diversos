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

        public static IList<Server> getServers()
        {
            IList<Server> servers = new List<Server>();
            servers.Add(new Server() { serverName = "Antibes" });
            servers.Add(new Server() { serverName = "Beder" });
            servers.Add(new Server() { serverName = "Ebelfort" });
            servers.Add(new Server() { serverName = "Grenoble" });
            servers.Add(new Server() { serverName = "Jyllinge" });
            servers.Add(new Server() { serverName = "Hamamatsu" });
            servers.Add(new Server() { serverName = "Kobe" });
            servers.Add(new Server() { serverName = "Lille" });
            servers.Add(new Server() { serverName = "Niort" });
            servers.Add(new Server() { serverName = "Nordby" });
            servers.Add(new Server() { serverName = "Oita" });
            servers.Add(new Server() { serverName = "Praesto" });
            servers.Add(new Server() { serverName = "Rouen" });
            servers.Add(new Server() { serverName = "Saga" });
            servers.Add(new Server() { serverName = "Soro" });
            servers.Add(new Server() { serverName = "Stoholm" });
            servers.Add(new Server() { serverName = "Vamdrup" });
            servers.Add(new Server() { serverName = "Viborg" });
            servers.Add(new Server() { serverName = "Vicky" });

            return servers;
        }
    }
}
