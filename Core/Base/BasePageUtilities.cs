namespace Core.Base
{
    public abstract partial class BasePage
    {
        public string Create_FilterField(string fieldToFilter, int size = 4)
        {
            return (fieldToFilter.Substring(0, fieldToFilter.Length - size));
        }

    }
}
