namespace OR_Modules.Model.DTO
{
    public sealed class UrlSettings_DTO
    {
        public string Site { get; set; }
        public bool SingleSignOn { get; set; }
        public string LocalUrl { get; set; }
        public string DoeUatOrUrl { get; set; }
        public string DoeDevOrUrl { get; set; }
        public string DoePrdOrUrl { get; set; }
    }

    public class UserSettings_DTO
    {
        public string UserId { get; set; }
        public string UserPassword { get; set; }
    }
}