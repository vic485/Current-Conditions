namespace DataModels
{
    public class SettingsModel
    {
        public string ApiKey { get; set; } = string.Empty;
        public int WaitMin { get; set; } = 15;
        public bool AutoLocation { get; set; }
        public string City { get; set; }
    }

}
