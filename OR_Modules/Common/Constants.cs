namespace OR_Modules.Common
{
    public static class OR_Constants
    {

        public static class SITE
        {
            public const string LOCAL = "LOCAL";
            public const string DOE_DEV_OR = "DOE_DEV_OR";
            public const string DOE_UAT_OR = "DOE_UAT_OR";
            public const string DOE_PRD_OR = "DOE_PRD_OR";
        }

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

        public static class SearchByFieldOptions
        {
            public const string ProjectUpdate = "Project Update";
            public const string Contact = "Contact";
            public const string Participant = "Participant";
        }

        public static class TITLE
        {
            public const string ActionRequest = "Action Request";
        }

        public static class URL
        {
            // Modals
            public const string Modal = "Modals dont have URLs or Titles";

            // Pages
            public const string ContactSummary = "Contact/Summary.html#Energy";

            // Login
            public const string Login = "login.html";
        }
    }
}