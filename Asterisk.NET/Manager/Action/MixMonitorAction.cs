using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterisk.NET.Manager.Action
{
    public class MixMonitorAction : ManagerAction
    {
        private string channel;
        private string file;
        private string options;
        private string command;

        public override string Action
        {
            get { return "MixMonitor"; }
        }

        public string Channel
        {
            get { return this.channel; }
            set { this.channel = value; }
        }

        public string File
        {
            get { return this.file; }
            set { this.file = value; }
        }

        public string Options
        {
            get { return this.options; }
            set { this.options = value; }
        }

        public string Command
        {
            get { return this.command; }
            set { this.command = value; }
        }

    }
}
