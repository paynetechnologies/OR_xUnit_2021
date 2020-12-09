namespace Core.Common
{
    public static class Constants
    {
        public const string APPLICATION_PREFIX = "OR";
        public const string PINWHEELOVERLAY = "PinwheelOverlay";
        public const string PINWHEELMODALOVERLAY = "PinwheelModalOverlay";

        // DOE
        //public const string LOGIN_USER = @"DOE\Michael.Rodriguez";
        //public const string LOGIN_PASSWORD = "Energy";

        // Graphite/My Local VM
        public const string LOGIN_USER = @"ScottH";
        public const string LOGIN_PASSWORD = "Energy";

        public enum OrderBy_Enum
        {
            Ascending,
            Descending
        }

        public static class Status
        {
            public const string Active = "Active";
            public const string Inactive = "Inactive";
        }
        
        #region Outreach
        #endregion
    }
}