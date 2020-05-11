namespace RotMG_Net_Lib.Networking
{
    public class DisconnectReason
    {
        public static readonly DisconnectReason EofHead = new DisconnectReason("End of file on head");
        public static readonly DisconnectReason EofBody = new DisconnectReason("End of file on body");
        public static readonly DisconnectReason ExceptionOnListener = new DisconnectReason("Exception on listener");
        public static readonly DisconnectReason ExceptionOnListenerStart = new DisconnectReason("Exception on listener start");
        public static readonly DisconnectReason EmailVerificationNeeded = new DisconnectReason("Email verification needed");
        public static readonly DisconnectReason ProtocolError = new DisconnectReason("Protocol error");
        
        public static readonly DisconnectReason RequestedByUser = new DisconnectReason("Requested by user");
        

        public readonly string Reason;

        public DisconnectReason(string Reason)
        {
            this.Reason = Reason;
        }

    }
}