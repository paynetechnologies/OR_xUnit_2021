using System.IO;
using System.Linq;
using System.Reflection;
using Core.Configuration;
using Microsoft.Extensions.Configuration;
using OR_Modules.Model.DTO;

namespace OR_Modules.Configuration
{
    public sealed class ConfigurationService
    {
        // Singleton
        private static ConfigurationService _instance;
        public ConfigurationService() => Root = InitializeConfiguration();

        public static ConfigurationService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationService();
                }
                return _instance;
            }
        }
        public IConfigurationRoot Root { get; }

        // User Login Settings
        public UserSettings_DTO GetUserSettings()
        {
            var result = ConfigurationService.Instance.Root.GetSection("userSettings").Get<UserSettings_DTO>();
            if (result == null)
            {
                throw new  ConfigurationNotFoundException(typeof(UserSettings_DTO).ToString());
            }
            return result;
        }

        // URL Settings
        public UrlSettings_DTO GetUrlSettings()
        {
            var result = ConfigurationService.Instance.Root.GetSection("urlSettings").Get<UrlSettings_DTO>();
            if (result == null)
            {
                throw new ConfigurationNotFoundException(typeof(UrlSettings_DTO).ToString());
            }
            return result;
        }

        // Participant_Contact_Profiles Settings
        //public ParticipantContactProfile_DTO GetParticipantContactProfiles()
        //{
        //    var result = ConfigurationService.Instance.Root.GetSection("Participant_Contact_Profile").Get<ParticipantContactProfile_DTO>();
        //    if (result == null)
        //    {
        //        throw new ConfigurationNotFoundException(typeof(ParticipantContactProfile_DTO).ToString());
        //    }
        //    return result;
        //}
        //OR_1572
        //public OR_1572_TestData_DTO Get_OR_1572_TestData()
        //{
        //    var result = ConfigurationService.Instance.Root.GetSection("OR_1572_TestData").Get<OR_1572_TestData_DTO>();
        //    if (result == null)
        //    {
        //        throw new ConfigurationNotFoundException(typeof(OR_1572_TestData_DTO).ToString());
        //    }
        //    return result;
        //}

            // Browswer Settings
        public WebSettings_DTO GetWebSettings()
            => ConfigurationService.Instance.Root.GetSection("webSettings").Get<WebSettings_DTO>();

        // Standard 
        private IConfigurationRoot InitializeConfiguration()
        {
            var filesInExecutionDir = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            var settingsFile =
                filesInExecutionDir.FirstOrDefault(x => x.Contains("testFrameworkSettings") && x.EndsWith(".json"));

            var builder = new ConfigurationBuilder();

            if (settingsFile != null)
            {
                builder.AddJsonFile(settingsFile, optional: true, reloadOnChange: true);
            }
            return builder.Build();
        }
    }
}