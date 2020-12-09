using Core.Configuration;
using Flurl;
using OR_Modules.Common;

namespace OR_Modules.Configuration
{
    public static class UrlDeterminer
    {
        public static string GetSite(string urlPart)
        {
            var site =  ConfigurationService.Instance.GetUrlSettings().Site;
            string content = "content"; // http://www.example.com/content/myexamplepage.html
            if (site == OR_Constants.SITE.LOCAL)
            {
                return Url.Combine(ConfigurationService.Instance.GetUrlSettings().LocalUrl, content, urlPart).ToString();
            }
            else if(site == OR_Constants.SITE.DOE_UAT_OR)
            {
                return Url.Combine(ConfigurationService.Instance.GetUrlSettings().DoeUatOrUrl, content, urlPart).ToString();
            }
            else if (site == OR_Constants.SITE.DOE_DEV_OR)
            {
                return Url.Combine(ConfigurationService.Instance.GetUrlSettings().DoeDevOrUrl, content, urlPart).ToString();
            }
            else if (site == OR_Constants.SITE.DOE_PRD_OR)
            {
                return Url.Combine(ConfigurationService.Instance.GetUrlSettings().DoePrdOrUrl, content, urlPart).ToString();
            }
            else
            {
                throw new ConfigurationNotFoundException("URL Settings Site not found.");
            }
        }
    }
}
