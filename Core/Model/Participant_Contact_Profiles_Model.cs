using Core.Configuration;

namespace Core.Model
{
    public class Participant_Contact_Profiles_Model
    {
        public string ContactName { get; set; } = ConfigurationService.Instance.GetParticipantContactProfiles().ContactName;
        public string LoanProfileName { get; set; } = ConfigurationService.Instance.GetParticipantContactProfiles().LoanProfileName;
        public string OrderBy { get; set; } = ConfigurationService.Instance.GetParticipantContactProfiles().OrderBy;
        public string ParticipantName { get; set; } = ConfigurationService.Instance.GetParticipantContactProfiles().ParticipantName;
        public string SearchFor { get; set; } = ConfigurationService.Instance.GetParticipantContactProfiles().SearchFor;
        public string SortBy { get; set; } = ConfigurationService.Instance.GetParticipantContactProfiles().SortBy;
        public string Status { get; set; } = ConfigurationService.Instance.GetParticipantContactProfiles().Status;
    }
}
