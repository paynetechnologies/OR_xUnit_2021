
using Core.Common;
using OpenQA.Selenium;

namespace OR_Organizations_Report
{
    public partial class Organizations_Report
    {
        public void FillForm()
        {
            
            IsVisible(By.Id("FromDateField"));
            FromDateField.Clear();
            SendData(FromDateField, "1");
            
            IsClickable(ProgramField);
            ProgramFieldOption.SelectByIndex(1);
            
            IsClickable(SectorField);
            SectorFieldOption.SelectByIndex(1);
            
            IsClickable(SolicitationField);
            SolicitationFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("ToDateField"));
            ToDateField.Clear();
            SendData(ToDateField, "1");
            
            IsClickable(TypeField);
            TypeFieldOption.SelectByIndex(1);

        } // close FillForm
    } // close class
} // close namespace
        
        
