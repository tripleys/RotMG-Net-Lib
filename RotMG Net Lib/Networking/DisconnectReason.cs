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
        public static readonly DisconnectReason ExceptionOnConnection = new DisconnectReason("Exception while connecting to server");
        public static readonly DisconnectReason ExceptionOnProcessPacket = new DisconnectReason("Exception on packet processing.");
        public static readonly DisconnectReason AccountInUse = new DisconnectReason("Account in use.");

        public readonly string Reason;
        public string Details;

        public DisconnectReason(string reason, string details = null)
        {
            this.Reason = reason;
            this.Details = details;
        }

        public DisconnectReason SetDetails(string details)
        {
            this.Details = details;
            return this;
        }


        #region Equals

        protected bool Equals(DisconnectReason other)
        {
            return Reason == other.Reason;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((DisconnectReason) obj);
        }

        public override int GetHashCode()
        {
            return (Reason != null ? Reason.GetHashCode() : 0);
        }

        #endregion
    }
}