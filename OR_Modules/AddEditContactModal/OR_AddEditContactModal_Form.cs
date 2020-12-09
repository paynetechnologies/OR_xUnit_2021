
using Core.Common;
using OpenQA.Selenium;

namespace OR_AddEditContactModal
{
    public partial class AddEditContactModal
    {
        public void FillForm()
        {
            
            IsVisible(By.Id("AddressLine1Field"));
            AddressLine1Field.Clear();
            SendData(AddressLine1Field, "1");
            
            IsVisible(By.Id("AddressLine2Field"));
            AddressLine2Field.Clear();
            SendData(AddressLine2Field, "1");
            
            IsVisible(By.Id("BusinessPhoneField"));
            BusinessPhoneField.Clear();
            SendData(BusinessPhoneField, "1");
            
            IsVisible(By.Id("CityField"));
            CityField.Clear();
            SendData(CityField, "1");
            
            IsVisible(By.Id("CompanyPhoneField"));
            CompanyPhoneField.Clear();
            SendData(CompanyPhoneField, "1");
            
            IsVisible(By.Id("ContactAddressLine1Field"));
            ContactAddressLine1Field.Clear();
            SendData(ContactAddressLine1Field, "1");
            
            IsVisible(By.Id("ContactAddressLine2Field"));
            ContactAddressLine2Field.Clear();
            SendData(ContactAddressLine2Field, "1");
            
            IsVisible(By.Id("ContactCityField"));
            ContactCityField.Clear();
            SendData(ContactCityField, "1");
            
            IsClickable(ContactStateField);
            ContactStateFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("ContactZipField"));
            ContactZipField.Clear();
            SendData(ContactZipField, "1");
            
            IsVisible(By.Id("EmailField"));
            EmailField.Clear();
            SendData(EmailField, "1");
            
            IsVisible(By.Id("FirstNameField"));
            FirstNameField.Clear();
            SendData(FirstNameField, "1");
            
            IsVisible(By.Id("LastNameField"));
            LastNameField.Clear();
            SendData(LastNameField, "1");
            
            IsVisible(By.Id("MiddleNameField"));
            MiddleNameField.Clear();
            SendData(MiddleNameField, "1");
            
            IsVisible(By.Id("MobilePhoneField"));
            MobilePhoneField.Clear();
            SendData(MobilePhoneField, "1");
            
            IsVisible(By.Id("OrganizationNameFilteredField"));
            OrganizationNameFilteredField.Clear();
            SendData(OrganizationNameFilteredField, "1");
            
            IsClickable(OrganizationTypeField);
            OrganizationTypeFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("OrganizationWebsiteField"));
            OrganizationWebsiteField.Clear();
            SendData(OrganizationWebsiteField, "1");
            
            IsClickable(OwnerField);
            OwnerFieldOption.SelectByIndex(1);
            
            IsClickable(ProgramField);
            ProgramFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("SameAddressField"));
            SameAddressField.Clear();
            SendData(SameAddressField, "1");
            
            IsClickable(SectorField);
            SectorFieldOption.SelectByIndex(1);
            
            IsClickable(SolicitationField);
            SolicitationFieldOption.SelectByIndex(1);
            
            IsClickable(StateField);
            StateFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("TitleField"));
            TitleField.Clear();
            SendData(TitleField, "1");
            
            IsVisible(By.Id("ZipField"));
            ZipField.Clear();
            SendData(ZipField, "1");

        } // close FillForm
    } // close class
} // close namespace
        
        
