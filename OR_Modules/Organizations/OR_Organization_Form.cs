//Generated : 2020-12-17
using OR_Modules.Model;
using OpenQA.Selenium;

namespace OR_Modules.Organization
{
    public partial class Organization
    {
        public void FillForm()
        {
            IsVisible(By.Id("ContactField"));
            ContactField.Clear();
            SendData(ContactField, Organization_Model.ContactField);
            
            IsVisible(By.Id("OrganizationField"));
            OrganizationField.Clear();
            SendData(OrganizationField, Organization_Model.OrganizationField);
            
            IsClickable(SectorField);
            SectorFieldOption.SelectByIndex(Organization_Model.SectorField);
            
        } // close FillForm
    }
}
