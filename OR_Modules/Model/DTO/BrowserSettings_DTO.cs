using Core.Configuration;

namespace OR_Modules.Model.DTO
{
    public sealed class WebSettings_DTO
    {
        public string BaseUrl { get; set; }
        public BrowserSettings Chrome { get; set; }
        public BrowserSettings Firefox { get; set; }
        public BrowserSettings Edge { get; set; }
        public BrowserSettings Opera { get; set; }
        public BrowserSettings InternetExplorer { get; set; }
        public BrowserSettings Safari { get; set; }
        public int ElementWaitTimeout { get; set; }
    }

    //public class WebSettings
    //{
    //    public string elementWaitTimeout { get; set; }
    //    public Chrome chrome { get; set; }
    //    public FireFox fireFox { get; set; }
    //    public Edge edge { get; set; }
    //    public InternetExplorer internetExplorer { get; set; }
    //    public Opera opera { get; set; }
    //    public Safari safari { get; set; }
    //}

    public class Chrome
    {
        public string pageLoadTimeout { get; set; }
        public string scriptTimeout { get; set; }
        public string artificialDelayBeforeAction { get; set; }
    }

    public class FireFox
    {
        public string pageLoadTimeout { get; set; }
        public string scriptTimeout { get; set; }
        public string artificialDelayBeforeAction { get; set; }
    }

    public class Edge
    {
        public string pageLoadTimeout { get; set; }
        public string scriptTimeout { get; set; }
        public string artificialDelayBeforeAction { get; set; }
    }

    public class InternetExplorer
    {
        public string pageLoadTimeout { get; set; }
        public string scriptTimeout { get; set; }
        public string artificialDelayBeforeAction { get; set; }
    }

    public class Opera
    {
        public string pageLoadTimeout { get; set; }
        public string scriptTimeout { get; set; }
        public string artificialDelayBeforeAction { get; set; }
    }

    public class Safari
    {
        public string pageLoadTimeout { get; set; }
        public string scriptTimeout { get; set; }
        public string artificialDelayBeforeAction { get; set; }
    }

}