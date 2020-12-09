
using Core.Common;
using OpenQA.Selenium;

namespace OR_Follow_Ups
{
    public partial class Follow_Ups
    {
        public void FillForm()
        {
            
            IsClickable(CompleteSelectField);
            CompleteSelectFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("ContactField"));
            ContactField.Clear();
            SendData(ContactField, "1");
            
            IsClickable(FollowupTypeField);
            FollowupTypeFieldOption.SelectByIndex(1);
            
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
        
        
