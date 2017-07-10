namespace Asterisk.NET.Manager.Event
{
	/// <summary>
	/// A dial event is triggered whenever a phone attempts to dial someone.<br/>
	/// This event is implemented in <code>apps/app_dial.c</code>.<br/>
	/// Available since Asterisk 1.2.
	/// </summary>
	public class DialBeginEvent : ManagerEvent
	{
        public string ChannelState { get; set; }
        public string ChannelStateDesc { get; set; }
        public string CallerIDNum { get; set; }
        public string CallerIDName { get; set; }
        public string ConnectedLineNum { get; set; }
        public string ConnectedLineName { get; set; }
        public string AccountCode { get; set; }
        public string Context { get; set; }
        public string Exten { get; set; }
        public string Priority { get; set; }
        public string Linkedid { get; set; }
        public string DestChannel { get; set; }
        public string DestChannelState { get; set; }
        public string DestChannelStateDesc { get; set; }
        public string DestCallerIDNum { get; set; }
        public string DestCallerIDName { get; set; }
        public string DestConnectedLineNum { get; set; }
        public string DestConnectedLineName { get; set; }
        public string DestAccountCode { get; set; }
        public string DestContext{ get; set;}
        public string DestExten { get; set; }
        public string DestPriority { get; set; }
        public string DestUniqueid { get; set; }
        public string DestLinkedid { get; set; }
        public string DialString { get; set; }
        
		/// <summary>
		/// Creates a new DialBeginEvent.
		/// </summary>
		public DialBeginEvent(ManagerConnection source)
			: base(source)
		{
		}
	}
}