using Grahphite_Namespace;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Grahphite_Namespace
{
    public class User
    {
        public Person Person { get; set; }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PortalHeaderPack
    {
        public PortalHeaderPack Build(User CurrentUser, PortalHeaderPack PortalHeader)
        {
            return PortalHeader;
        }
    }

    public class Account_Home {  }

    public class Account
    {
        public bool Active { get; set; }
        public decimal Balance { get; set; }
        public string Number { get; set; }
        public AccountType Type { get; set; }

        //HowToDictionaryInitializer
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-a-dictionary-with-a-collection-initializer
        public class AccountType
        {
            public Dictionary<string, string> t = new Dictionary<string, string>()
            {
                //{ {"Display", "AutoInsurance" }, {"value", "Auto Instruance" } }
            };

            public string Display { get; set; }
        }
    }

    public class AccountPanel
    {
        public List<AccountCard> Cards { get; set; }
    }

    public class AccountCard
    {
        public AccountCard() { }
        public AccountCardArea AccountCardArea { get; set;}
    }

    public class AccountCardArea
    {
        public AccountCardArea() { }
        public string AccountTypeHeading { get; set; }
        public string AccountBalanceHeading { get; set; }
    }

    public static class External
    {
        public static decimal FormatCurrency(decimal currency)
        {
            decimal formatted = 1.1M;
            return formatted;
        }

        public static string GetPeriodOfDay()
        {
            var currentHour = DateTime.Now.Hour;
            if (currentHour < 12)
            {
                return "Good Morning";
            }
            else if (currentHour < 17)
            {
                return "Good Afternoon";
            }
            else
            {
                return "Good Evening";
            }
        }
    }

    public class Member
    {
        //public SortedList<Account, string> Accounts;
        public List<Account> Accounts;
    }

    public class graphite
    {
        public List<AccountCard> BuildAccountCards(List<Account> Accounts)
        {
            List<AccountCard> AccountCards = new List<AccountCard>();

            foreach (Account AccountInContext in Accounts)
            {
                var HomeBuildAccountCardResult = BuildAccountCard(AccountInContext);
                AccountCards.Add(HomeBuildAccountCardResult);
                //AccountCards.Add(HomeBuildAccountCardResult.Outputs.NewAccountCard);
            }
            return AccountCards;
        }

        public AccountCard BuildAccountCard(Account AccountInContext)
        {
            AccountCard NewAccountCard = new AccountCard();

            var LastFiveDigits = AccountInContext.Number.Substring(
                AccountInContext.Number.Length - 5);

            var AccountTypeDisplay = AccountInContext.Type.Display + "..." + LastFiveDigits;

            var FormatCurrencyResult = External.FormatCurrency(AccountInContext.Balance);

            NewAccountCard.AccountCardArea.AccountTypeHeading = AccountTypeDisplay;
            NewAccountCard.AccountCardArea.AccountBalanceHeading = "USD " + FormatCurrencyResult;

            return NewAccountCard;
        }

        public Account_Home BuildAccountPanel(Member MemberInContext, Account_Home View)
        {
            AccountPanel AccountPanel = new AccountPanel();

            var ActiveAccounts = (from x in MemberInContext.Accounts
                                 where x.Active == true
                                 orderby x.Number ascending
                                 select x).ToList();

            var HomeBuildAccountCardsResult = BuildAccountCards(ActiveAccounts);

            //does not compile AccountPanel.Cards.AddRange(HomeBuildAccountCardsResult.Outputs.AccountCards);

            return View;
        }

        public Account_Home OnLoadView(User CurrentUser)
        {
            Account_Home View = new Account_Home();

            PortalHeaderPack PortalHeaderPack = new PortalHeaderPack();
            var PortalHeaderPackResult  = 
                PortalHeaderPack.Build(CurrentUser, PortalHeaderPack);

            var GetPeriodOfDayResult = External.GetPeriodOfDay();
            var PeriodOfDayHeading = GetPeriodOfDayResult + ",";
            var WelcomeHeading = "Welcome Back " + CurrentUser.Person.FirstName +
                " " + CurrentUser.Person.LastName;

            //does not compile var HomeBuildAccountPanelResult = BuildAccountPanel((Member)CurrentUser, View);

            //does not compile return HomeBuildAccountPanelResult; //.Outputs.View;
            return View;
        }
    }
}
