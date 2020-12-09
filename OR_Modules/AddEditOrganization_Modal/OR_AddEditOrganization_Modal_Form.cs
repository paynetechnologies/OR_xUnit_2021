
using Core.Common;
using OpenQA.Selenium;

namespace OR_AddEditOrganization_Modal
{
    public partial class AddEditOrganization_Modal
    {
        public void FillForm()
        {
            
            IsVisible(By.Id("AddressLine2TextField"));
            AddressLine2TextField.Clear();
            SendData(AddressLine2TextField, "1");
            
            IsVisible(By.Id("AddressTextField"));
            AddressTextField.Clear();
            SendData(AddressTextField, "1");
            
            IsVisible(By.Id("CityTextField"));
            CityTextField.Clear();
            SendData(CityTextField, "1");
            
            IsVisible(By.Id("OrganizationNameTextField"));
            OrganizationNameTextField.Clear();
            SendData(OrganizationNameTextField, "1");
            
            IsVisible(By.Id("OrganizationPhoneTextField"));
            OrganizationPhoneTextField.Clear();
            SendData(OrganizationPhoneTextField, "1");
            
            IsClickable(OrganizationTypeSelectField);
            OrganizationTypeSelectFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("OrganizationWebsiteTextField"));
            OrganizationWebsiteTextField.Clear();
            SendData(OrganizationWebsiteTextField, "1");
            
            IsVisible(By.Id("ProgramsCheckboxFieldGTCUn6DedTUYoYkAj2DhhBOzg6161"));
            ProgramsCheckboxFieldGTCUn6DedTUYoYkAj2DhhBOzg6161.Clear();
            SendData(ProgramsCheckboxFieldGTCUn6DedTUYoYkAj2DhhBOzg6161, "1");
            
            IsVisible(By.Id("ProgramsCheckboxFieldGTCg6yLH436BQQ9C9QQzKBBBGw6161"));
            ProgramsCheckboxFieldGTCg6yLH436BQQ9C9QQzKBBBGw6161.Clear();
            SendData(ProgramsCheckboxFieldGTCg6yLH436BQQ9C9QQzKBBBGw6161, "1");
            
            IsVisible(By.Id("ProgramsCheckboxFieldGTCoR8of2mFXo47s6Nq0xHb8kA6161"));
            ProgramsCheckboxFieldGTCoR8of2mFXo47s6Nq0xHb8kA6161.Clear();
            SendData(ProgramsCheckboxFieldGTCoR8of2mFXo47s6Nq0xHb8kA6161, "1");
            
            IsClickable(StateSelectField);
            StateSelectFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("ZipCodeTextField"));
            ZipCodeTextField.Clear();
            SendData(ZipCodeTextField, "1");

        } // close FillForm
    } // close class
} // close namespace
        
        
