
using Core.Common;
using OpenQA.Selenium;

namespace OR_Login
{
    public partial class Login
    {
        public void FillForm()
        {
            
            IsVisible(By.Id("PasswordField"));
            PasswordField.Clear();
            SendData(PasswordField, "1");
            
            IsVisible(By.Id("UsernameField"));
            UsernameField.Clear();
            SendData(UsernameField, "1");

        } // close FillForm
    } // close class
} // close namespace
        
        
