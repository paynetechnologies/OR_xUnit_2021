//Generated : 2020-12-17
using OR_Modules.Configuration;
using OR_Modules.Model.DTO;

namespace OR_Modules.Model
{
    public static class Organization_Model
    {
        public static string ContactField {get; set;} = ConfigurationService.Instance.Get_QS_2498_Organization_TestData().ContactName;
        public static string OrganizationField {get; set;} = ConfigurationService.Instance.Get_QS_2498_Organization_TestData().OrganizationName;
        public static int SectorField {get; set;} = ConfigurationService.Instance.Get_QS_2498_Organization_TestData().SectorName;
    }

    //// Both do the same thing but which method makes more sense?
    //public static class Organization_Model_X
    //{
    //    public static QS_2498_Organization_TestData_DTO Data { get; set; } = ConfigurationService.Instance.GetOrganizationSettings();

    //    public static string ContactField { get; set; } = Data.ContactField;
    //    public static string OrganizationField { get; set; } = Data.OrganizationField;
    //    public static int SectorField { get; set; } = Data.SectorField;
    //}
}
