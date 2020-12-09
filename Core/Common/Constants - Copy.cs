namespace Core.Common
{
    public static class Constants_Copy
    {
        public const string APPLICATION_PREFIX = "AP";

        //Json public const string ExcelFilePath = @"\AP_Core\Test_Data\Application_Portal_TestData.xlsx";


        public const string PINWHEELOVERLAY = "PinwheelOverlay";
        public const string PINWHEELMODALOVERLAY = "PinwheelModalOverlay";

        public enum OrderBy_Enum
        {
            Ascending,
            Descending
        }

        public static class Status
        {
            public const string Active = "Active";
            public const string Inactive = "Inactive";
        }


        public static class ApplicantInformation
        {
            public const string Title = TITLE.ApplicantInformation;
            public const string ApplicationCreationModal = "IframeApplicationApplicationCreationModal";
            public const string Url = URL.ApplicantInformation;
        }

        public static class UserRegistration
        {
            public const string Title = TITLE.UserRegistration;
            public const string NewApplicantModal = "IframeNewApplicantsModal";
            public const string Url = URL.NEWAPPLICANT;
        }

        public static class URL
        {
            // DOE UAT
            //public override string Url => @"https://dart-uat.loanprograms.energy.gov/Content/Login.html";
            //public const string BASE = "https://dart-uat.loanprograms.energy.gov/Content";
            
            // GraphiteGTC
            //public const string BASE = "http://energy.graphitegtc.com/Content";
            
            // My Local VM
            public const string BASE = "http://192.168.23.132:8099/Content";

            public const string ConfirmPasscode = BASE + "/ConfirmPasscode.html";
            public const string ForgotPassword = BASE + "/ForgotPassword.html";
            public const string ForgotPassword_Passcode = BASE + "/";
            public const string ForgotPassword_TempPassword = BASE + "/";
            public const string Login = BASE + "/Login.html";
            public const string NEWAPPLICANT = BASE + "/UserRegistationModal.html";

            public const string ApplicantInformation = BASE + "/TitleXVIIApplication/EditApplicantInformation.html";
            public const string DocumentUpload = BASE + "/TitleXVIIApplication/DocumentUploadPartI.html";
            public const string PreliminaryQuestions = BASE + "/TitleXVIIApplication/EditPreliminaryQuestions.html";
            public const string ProjectInfo = BASE + "/TitleXVIIApplication/EditProjectInformation.html";
            public const string ProjectLocation = BASE + "/TitleXVIIApplication/EditProjectLocations.html";
            public const string ProjectSponsors = BASE + "/TitleXVIIApplication/EditProjectSponsors.html";
            public const string ReviewAndSubmit = BASE + "/TitleXVIIApplication/ReviewAndSubmitPartI.html";
            public const string SecurityMessage = BASE + "/SecurityMessage.html";
            public const string SummaryOfRequest = BASE + "/TitleXVIIApplication/EditSummaryOfRequest.html";

            public const string ApplicationCreationModalTest = BASE + "/Application/ApplicationCreationModal.html";
        }

        public static class TITLE
        {
            public const string ConfirmPasscode = "Confirm Passcode";
            public const string ForgotPassword = "Forgot Password";
            public const string ForgotPassword_Passcode = "Forgot Password Passcode";
            public const string ForgotPassword_TempPassword = "Forgot Password TempPassword";

            public const string ApplicantInformation = "Applicant Information";
            public const string ApplicationCreationModalTest = "Application Creation"; 
            public const string DocumentUpload = "Document Upload";
            public const string Login = "Login";
            public const string PreliminaryQuestions = "Preliminary Questions";
            public const string ProjectInfo = "Project Information";
            public const string ProjectLocation = "Project Location(s)";
            public const string ProjectSponsors = "Project Sponsor(s)";
            public const string ReviewAndSubmit = "Review and Submit";
            public const string SecurityMessage = "Security Message";
            public const string SummaryOfRequest = "Summary of Request";
            public const string UserRegistration = "User Registration";
        }

        public static class DOCUMENT_UPLOAD
        {
            public const int Option_to_Restrict_Disclosure_and_Use_of_Certain_Data = 1;
            public const int Organization_Corporate_and_Personnel = 2;
            public const int Project_Description = 3;
            public const int Technical_Information = 4;
            public const int Legal_and_Regulatory_Information = 5;
            public const int Business_and_Financial_Plans = 6;
            public const int Application_Certifications = 7;
        }

        public static class QS
        {
            public static class TITLE
            {
                public const string Home = "Home";
                public const string Login = "Login";
                public const string ManageLoans = "Manage Loans";
                public const string MonitoringActivities = "Monitoring Activities";
                public const string MonitoringActivities_ProjectUpdate = "MonitoringActivities_ProjectUpdate";
                public const string ProjectUpdates_Summary = "Summary";
                public const string ParticipantContactProfiles = "Participant/ Contact Profiles";

                public const string Participant_Summary = "Participant Home";
                public const string Participant_Summary_Overview = "Participant Home";
                public const string Participant_Summary_Locations = "Participant Home";
                public const string Participant_Summary_Roles = "Participant Home";
                public const string Participant_Summary_Contacts = "Participant Home";

                public const string Contact_Summary = "Participant_Home";
                public const string Contact_Summary_Overview = "Contact";
                public const string Contact_Summary_Edit_Contact = "Edit Contact";
                public const string Add_Contact_Modal = "Add Contact";

                public const string Task_AddTaskModal = "Add Task";
                public const string Task_AddTask = "Add Task";
                public const string Task = "Task";
            }

            public static class URL
            {
                // My Local VM
                public const string BASE = "http://192.168.23.132:8095/Content";

                // GraphiteGTC
                //public const string BASE = "http://energy.graphitegtc.com/Content";

                // Graphite QA Server
                //public override string Url => @"http://energy.graphitegtc.com/content/login.html";

                // Login
                //J public const string Login = BASE + "/login.html";

                // Home
                public const string Home = BASE + "/Home.html";

                // Tile Row 1
                public const string MyPortfolio = BASE + "/MyPortfolio/Home.html";
                public const string ManageProjects = BASE + "/ManageProjects/Home.html#Energy";
                public const string ManageLoans = BASE + "/ManageLoans/Home.html";
                public const string Tasks = BASE + "/Tasks/Home.html";

                // Tile Row 2
                public const string MarketRiskReports = BASE + "/MarketRiskReports/Home.html#Energy";
                public const string SectorRiskReports = BASE + "/SectorRiskReports/Home.html#Energy";
                public const string SystemAdministration = BASE + "/SystemAdministration/Home.html#Energy";
                public const string KnowledgeManagement = BASE + "/KnowledgeManagement/Home.html#Energy";

                // Tile Row 3
                public const string ManageApplications = BASE + "/ManageApplications/Home.html#Energy";
                public const string Operations = BASE + "/Operations/Landing.html#Energy";


                // Manage Projects - Projects Summary
                // 4 tabs: Project Information, Project Milestones, Project Metrics, Project Status Report
                public const string Projects_Summary = BASE + "/Projects/Summary.html#Energy";

                // Manage Loans - Loan Profile Summary
                // 7 tabs: Loan Infromation, Capitalization, Collateral, Program Information, Project Milestones, Davis Bacon Act Information, Amortization Schedules
                public const string LoanProfile_Summary = BASE + "/LoanProfile/Summary.html#Energy";

                // Task Summary
                public const string Task_Summary = BASE + "/Task/Summary.html#Energy";

                // Market Risk Summary
                public const string MarketRiskReports_Summary = BASE + "/MarketRiskReports/Summary.html";

                // Sector Risk Reports Summary
                public const string SectorRiskReports_Summary = BASE + "/SectorRiskReports/Summary.html#Energy";

                // Task
                public const string Task = BASE + "/Task/Summary.html#Energy";
                public const string Task_AddTask = BASE + "/Task/AddTaskModal.html";



                // ************************************************************
                // *                      Footers                             *
                // ************************************************************

                //Manage Projects Footer (left to right)
                public const string ManageProjectsFooter = BASE + "/ManageProjects/Home.html";
                public const string TechnicalReports = BASE + "/TechnicalReports/Home.html";
                public const string EnvironmentalReports = BASE + "/EnvironmentalReports/Home.html";
                public const string ProjectMetricsSummary = BASE + "/ProjectMetrics/ProjectMetricsSummary.html";
                public const string ProjectStatusReports = BASE + "/ProjectStatusReports/Home.html";

                
                // TODO: Manage Project Footer Summaries

                
                // Manage Loans Footer (left to right)
                public const string ManageLoansFooter = BASE + "/ManageLoans/Home.html#Energy";
                public const string CounterpartyRiskReports = BASE + "/CounterpartyRiskReports/Home.html";
                //J public const string ParticipantContactProfiles = BASE + "/ParticipantContactProfiles/Home.html";
                public const string PostIssueRequests = BASE + "/PostIssueRequests/Home.html";
                public const string MonitoringActivities = BASE + "/MonitoringActivities/Home.html";
                public const string DavisBaconActivities = BASE + "/DavisBaconActivities/Home.html";
                public const string LoanActivities = BASE + "/LoanActivities/Home.html";
                public const string WeeklyActivities = BASE + "/WeeklyActivities/Home.html";
                public const string CreditReports = BASE + "/CreditReports/Home.html";
                public const string FinancialMetrics = BASE + "/FinancialMetrics/Summary.html";


                // Manage Loans - Footer Summaries
                public const string CommunicationLog_Summary = BASE + "/CommunicationLog/Summary.html#Energy";
                public const string Contact_Summary = BASE + "/Contact/Summary.html#Energy"; 
                public const string CounterpartyRiskReports_Summary = BASE + "/CounterpartyRiskReports/Summary.html#Energy";
                public const string Covenant_Summary = BASE + "/Covenant/Summary.html#Energy";
                public const string IncidentLog_Summary = BASE + "/IncidentLog/Summary.html#Energy";

                
                // Participant_Summary
                // 4 tabs: Overview, Locations, Roles, Contacts
                //J public const string Participant_Summary = BASE + "/Participant/Summary.html#Energy";
                public const string Participant_Home = BASE + "/Participant/Summary.html#OverviewTab";
                public const string Participant_Locations = BASE + "/Participant/Summary.html#LocationsTab";
                public const string Participant_Roles = BASE + "/Participant/Summary.html#RoleTab";
                public const string Participant_Contacts = BASE + "/Participant/Summary.html#ContactsTab";
                public const string ProjectUpdates_Summary = BASE + "/ProjectUpdates/Summary.html#Energy";
                public const string TransferReport_Summary = BASE + "/TransferReport/Summary.html";
                public const string TripReport_Summary = BASE + "/TripReport/Summary.html#Energy";
                public const string TripRequest_Summary = BASE + "/TripRequest/Summary.html#Energy";

                //J public const string Contact_Summary_Overview = BASE + "/Contact/Summary.html#Energy";
                public const string Contact_Summary_Edit_Contact = BASE + "/Contact/Summary.html#Energy";

                //public const string Add_Contact_Modal = BASE + "/Contact/ParticipantContactProfiles/Home.html#Energy";

                public const string Add_Contact_Modal = BASE + "/Contact/EditOverviewModal.html";


                // System Admin Tiles 
                public const string UserAdministration = BASE + "/SystemAdministration/UserAdministration.html#Energy";
                public const string CalendarAdministration = BASE + "/SystemAdministration/CalendarAdministration.html#Energy";
                public const string ConversionFactorAdministration = BASE + "/SystemAdministration/ConversionFactorAdministration.html#Energy";
                public const string PageSecurityAdministration = BASE + "/SystemAdministration/PageSecurityAdministration.html";
                public const string LoanAdministration = BASE + "/SystemAdministration/LoanAdministration.html#Energy";
                public const string EmailNotificationCriteriaAdministration = BASE + "/SystemAdministration/EmailNotificationCriteriaAdministration.html#Energy";
                public const string NightlyEmailAdministration = BASE + "/SystemAdministration/NightlyEmailAdministration.html#Energy";
                public const string KnowledgeManagementAdministration = BASE + "/SystemAdministration/KnowledgeManagement.html#Energy";
                public const string SystemTest = BASE + "/SystemAdministration/SystemTest.html#Energy";

                // Test
                public const string Test_Page_MonitoringActivities_ProjectUpdate = @"file:///C:/Users/payne/source/repos/ParsingHTML/ParsingHTML/QS_Files/MonitoringActivities_ProjectUpdate.html";

            }

            //public static class MonitoringActivities
            //{
            //    public static class SearchByFieldOptions
            //    {
            //        public const string ProjectUpdate = "Project Update";
            //    }
            //}

            public static class ParticipantContactProfiles
            {
                public static class SearchForFieldOptions
                {
                    public const string Contact = "Contact";
                    public const string Participant = "Participant";
                }
                public static class LoanProfileName_Filter
                {
                    public const string SOLAR_PARTNERS_II = "SOLAR PARTNERS II";
                }

                public const string PARTICIPANT_NAME = "Winston & Strawn LLP";
                public const string CONTACT_NAME = "Howard Payne";
            }

            public static class Status
            {
                public const string Active = "Active";
                public const string Inactive = "Inactive";
            }
        }
    }
}