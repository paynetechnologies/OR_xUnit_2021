
using Core.Common;
using OpenQA.Selenium;

namespace OR_Contacts
{
    public partial class Contacts
    {
        public void FillForm()
        {
            
            IsVisible(By.Id("ContactField"));
            ContactField.Clear();
            SendData(ContactField, "1");
            
            IsVisible(By.Id("OrganizationField"));
            OrganizationField.Clear();
            SendData(OrganizationField, "1");
            
            IsVisible(By.Id("SectorField"));
            SectorField.Clear();
            SendData(SectorField, "1");

        } // close FillForm
    } // close class
} // close namespace
        
        
