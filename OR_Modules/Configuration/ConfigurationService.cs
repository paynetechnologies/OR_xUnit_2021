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

        //Organization Settings
        // Add to OR_Modules/Configuration/ConfigurationServices.cs file
        public QS_2498_Organization_TestData_DTO Get_QS_2498_Organization_TestData()
        {
            var result = Instance.Root.GetSection("QS_2498_Organization_TestData").Get<QS_2498_Organization_TestData_DTO>();
            if (result == null)
            {
                throw new ConfigurationNotFoundException(typeof(QS_2498_Organization_TestData_DTO).ToString());
            }
            return result;
        }

        //Organization Settings
        // Add to OR_Modules/Configuration/ConfigurationServices.cs file
        public T GetSettings<T>(string sectionName) where T : QS_2498_Organization_TestData_DTO
        {
            var result = Instance.Root.GetSection(sectionName).Get<T>();
            if (result == null)
            {
                throw new ConfigurationNotFoundException(typeof(T).ToString());
            }
            return result;
        }

        //// Browswer Settings
        //public WebSettings_DTO GetWebSettings()
        //    => ConfigurationService.Instance.Root.GetSection("webSettings").Get<WebSettings_DTO>();

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