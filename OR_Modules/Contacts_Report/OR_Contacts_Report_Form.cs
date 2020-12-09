
using Core.Common;
using OpenQA.Selenium;

namespace OR_Contacts_Report
{
    public partial class Contacts_Report
    {
        public void FillForm()
        {
            
            IsVisible(By.Id("FromDateField"));
            FromDateField.Clear();
            SendData(FromDateField, "1");
            
            IsClickable(LPOOwnerField);
            LPOOwnerFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("OrganizationField"));
            OrganizationField.Clear();
            SendData(OrganizationField, "1");
            
            IsVisible(By.Id("ToDateField"));
            ToDateField.Clear();
            SendData(ToDateField, "1");

        } // close FillForm
    } // close class
} // close namespace
        
        
