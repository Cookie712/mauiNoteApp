namespace MauiApp1.Models
{
    class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms.maui";
        public string Message => "This app is written in .NET MAUI";
    }
}
