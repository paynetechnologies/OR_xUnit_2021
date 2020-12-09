
using Core.Common;
using OpenQA.Selenium;

namespace OR_AddEditAppointmentModal
{
    public partial class AddEditAppointmentModal
    {
        public void FillForm()
        {
            
            IsVisible(By.Id("ContactField"));
            ContactField.Clear();
            SendData(ContactField, "1");
            
            IsVisible(By.Id("DailyEveryNDaysField"));
            DailyEveryNDaysField.Clear();
            SendData(DailyEveryNDaysField, "1");
            
            IsVisible(By.Id("DailyWeekdayOnlyField"));
            DailyWeekdayOnlyField.Clear();
            SendData(DailyWeekdayOnlyField, "1");
            
            IsVisible(By.Id("FollowupAllDayField"));
            FollowupAllDayField.Clear();
            SendData(FollowupAllDayField, "1");
            
            IsVisible(By.Id("FollowupEndField"));
            FollowupEndField.Clear();
            SendData(FollowupEndField, "1");
            
            IsVisible(By.Id("FollowupRecurrenceFieldGTCQVxZqURnpQmc43hunYrsSPw6161"));
            FollowupRecurrenceFieldGTCQVxZqURnpQmc43hunYrsSPw6161.Clear();
            SendData(FollowupRecurrenceFieldGTCQVxZqURnpQmc43hunYrsSPw6161, "1");
            
            IsVisible(By.Id("FollowupRecurrenceFieldGTCUn6DedTUYoYkAj2DhhBOzg6161"));
            FollowupRecurrenceFieldGTCUn6DedTUYoYkAj2DhhBOzg6161.Clear();
            SendData(FollowupRecurrenceFieldGTCUn6DedTUYoYkAj2DhhBOzg6161, "1");
            
            IsVisible(By.Id("FollowupRecurrenceFieldGTCbZf5Z47ikQdfFCaLS3lMYtA6161"));
            FollowupRecurrenceFieldGTCbZf5Z47ikQdfFCaLS3lMYtA6161.Clear();
            SendData(FollowupRecurrenceFieldGTCbZf5Z47ikQdfFCaLS3lMYtA6161, "1");
            
            IsVisible(By.Id("FollowupRecurrenceFieldGTCg6yLH436BQQ9C9QQzKBBBGw6161"));
            FollowupRecurrenceFieldGTCg6yLH436BQQ9C9QQzKBBBGw6161.Clear();
            SendData(FollowupRecurrenceFieldGTCg6yLH436BQQ9C9QQzKBBBGw6161, "1");
            
            IsVisible(By.Id("FollowupRecurrenceFieldGTCoR8of2mFXo47s6Nq0xHb8kA6161"));
            FollowupRecurrenceFieldGTCoR8of2mFXo47s6Nq0xHb8kA6161.Clear();
            SendData(FollowupRecurrenceFieldGTCoR8of2mFXo47s6Nq0xHb8kA6161, "1");
            
            IsVisible(By.Id("FollowupStartField"));
            FollowupStartField.Clear();
            SendData(FollowupStartField, "1");
            
            IsVisible(By.Id("FollowupSubjectField"));
            FollowupSubjectField.Clear();
            SendData(FollowupSubjectField, "1");
            
            IsClickable(FollowupTypeField);
            FollowupTypeFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("IsCompleteSwitchField"));
            IsCompleteSwitchField.Clear();
            SendData(IsCompleteSwitchField, "1");
            
            IsVisible(By.Id("MonthlyEveryNMonthsField"));
            MonthlyEveryNMonthsField.Clear();
            SendData(MonthlyEveryNMonthsField, "1");
            
            IsVisible(By.Id("OrganizationField"));
            OrganizationField.Clear();
            SendData(OrganizationField, "1");
            
            IsClickable(OwnerField);
            OwnerFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("WeeklyEveryNWeeksField"));
            WeeklyEveryNWeeksField.Clear();
            SendData(WeeklyEveryNWeeksField, "1");
            
            IsClickable(WeeklyWeekdayField);
            WeeklyWeekdayFieldOption.SelectByIndex(1);
            
            IsVisible(By.Id("YearlyEveryNYearsField"));
            YearlyEveryNYearsField.Clear();
            SendData(YearlyEveryNYearsField, "1");

        } // close FillForm
    } // close class
} // close namespace
        
        
