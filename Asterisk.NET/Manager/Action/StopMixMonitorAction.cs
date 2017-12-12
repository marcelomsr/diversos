using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterisk.NET.Manager.Action
{
    public class StopMixMonitorAction : ManagerAction
    {

        private string channel;
        private string mixmonitorid;
        
        public override string Action
        {
            get { return "StopMixMonitor"; }
        }

        public string Channel
        {
            get { return this.channel; }
            set { this.channel = value; }
        }

        public string MixMonitorID
        {
            get { return this.mixmonitorid; }
            set { this.mixmonitorid = value; }
        }

    }
}
