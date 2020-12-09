
using Core.Common;
using OpenQA.Selenium;

namespace OR_Manage_Security_Groups
{
    public partial class Manage_Security_Groups
    {
        public void FillForm()
        {
            
            IsVisible(By.Id("AllowField"));
            AllowField.Clear();
            SendData(AllowField, "1");
            
            IsClickable(CopyFromSecurityGroupField);
            CopyFromSecurityGroupFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("NewSecurityGroupField"));
            NewSecurityGroupField.Clear();
            SendData(NewSecurityGroupField, "1");
            
            IsClickable(SecurityGroupField);
            SecurityGroupFieldOption.SelectByIndex(1);
            
            IsClickable(ViewDetailField);
            ViewDetailFieldOption.SelectByIndex(1);

        } // close FillForm
    } // close class
} // close namespace
        
        
