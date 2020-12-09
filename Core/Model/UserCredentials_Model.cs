using Core.Configuration;
using Core.Configuration;

namespace Core.Model
{
    public class UserCredentials_Model
    {
        public string User_Id { get; set; } = ConfigurationService.Instance.GetUserSettings().User_Id;
        public string User_Password { get; set; } = ConfigurationService.Instance.GetUserSettings().User_Password;
    }
}
