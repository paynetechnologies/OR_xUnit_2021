
using Core.Common;
using OpenQA.Selenium;

namespace OR_Organizations
{
    public partial class Organizations
    {
        public void FillForm()
        {
            
            IsVisible(By.Id("ContactField"));
            ContactField.Clear();
            SendData(ContactField, "1");
            
            IsVisible(By.Id("OrganizationField"));
            OrganizationField.Clear();
            SendData(OrganizationField, "1");
            
            IsClickable(SectorField);
            SectorFieldOption.SelectByIndex(1);

        } // close FillForm
    } // close class
} // close namespace
        
        
