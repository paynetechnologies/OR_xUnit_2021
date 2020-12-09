using OR_Modules.Configuration;
using OR_Modules.Model.DTO;

namespace OR_Modules.Model
{
    public class UrlSettingsModel 
    {
        public static UrlSettings_DTO UrlSettings { get; set; }
            = ConfigurationService.Instance.GetUrlSettings();

        public string Site { get; set; } = UrlSettings.Site;
        public bool SingleSignOn { get; set; } = UrlSettings.SingleSignOn;
        public string LocalUrl { get; set; } = UrlSettings.LocalUrl;
        public string DoeUatOrUrl { get; set; } = UrlSettings.DoeUatOrUrl;
        public string DoeDevOrUrl { get; set; } = UrlSettings.DoeDevOrUrl;
        public string DoePrdOrUrl { get; set; } = UrlSettings.DoePrdOrUrl;
    }

    public class UserSettingsModel 
    {
        public static UserSettings_DTO UserSettings { get; set; }
            = ConfigurationService.Instance.GetUserSettings();
        public string UserId { get; set; } = UserSettings.UserId;
        public string UserPassword { get; set; } = UserSettings.UserPassword; 
    }
}