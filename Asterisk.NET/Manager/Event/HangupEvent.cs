namespace Asterisk.NET.Manager.Event
{
	/// <summary>
	/// A HangupEvent is triggered when a channel is hung up.<br/>
	/// It is implemented in <code>channel.c</code>
	/// </summary>
    public class HangupEvent : ManagerEvent
	{
        public string ChannelState{ get; set;}
        public string ChannelStateDesc{ get; set;}
        public string CallerIDNum{ get; set;}
        public string CallerIDName{ get; set;}
        public string ConnectedLineNum{ get; set;}
        public string ConnectedLineName{ get; set;}
        public string AccountCode{ get; set;}
        public string Context{ get; set;}
        public string Exten{ get; set;}
        public string Priority{ get; set;}
        public string LinkedId{ get; set;}
        public string Cause{ get; set;}
        public string CauseTxt{ get; set;}

		public HangupEvent(ManagerConnection source)
			: base(source)
		{
		}
	}
}