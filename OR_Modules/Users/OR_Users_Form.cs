
using Core.Common;
using OpenQA.Selenium;

namespace OR_Users
{
    public partial class Users
    {
        public void FillForm()
        {
            
            IsVisible(By.Id("ConfirmPasswordField"));
            ConfirmPasswordField.Clear();
            SendData(ConfirmPasswordField, "1");
            
            IsVisible(By.Id("EmailField"));
            EmailField.Clear();
            SendData(EmailField, "1");
            
            IsVisible(By.Id("FirstNameField"));
            FirstNameField.Clear();
            SendData(FirstNameField, "1");
            
            IsVisible(By.Id("LastNameField"));
            LastNameField.Clear();
            SendData(LastNameField, "1");
            
            IsVisible(By.Id("MiddeNameField"));
            MiddeNameField.Clear();
            SendData(MiddeNameField, "1");
            
            IsVisible(By.Id("PasswordField"));
            PasswordField.Clear();
            SendData(PasswordField, "1");
            
            IsVisible(By.Id("PhoneField"));
            PhoneField.Clear();
            SendData(PhoneField, "1");
            
            IsClickable(SecurityGroupField);
            SecurityGroupFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("UsernameField"));
            UsernameField.Clear();
            SendData(UsernameField, "1");

        } // close FillForm
    } // close class
} // close namespace
        
        
