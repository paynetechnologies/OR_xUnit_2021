using Core.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
    public class URL_Model
    {
        public string Site { get; set; } = ConfigurationService.Instance.GetUrlSettings().Site;
        public string LocalUrl { get; set; } = ConfigurationService.Instance.GetUrlSettings().LocalUrl;
        public string GraphiteUrl { get; set; } = ConfigurationService.Instance.GetUrlSettings().GraphiteUrl;
        public string DOEUrl { get; set; } = ConfigurationService.Instance.GetUrlSettings().DOEUrl;
    }
}
