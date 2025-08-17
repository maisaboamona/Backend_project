namespace HomePage.Models.Home
{
    public class AboutItemViewModel
    {
        public string Title { get; set; }

        public string subTitle { get; set; }

        public string Urlimag { get; set; }

    }
    public class AboutViewModel
    {
        public IEnumerable<AboutItemViewModel> Items { get; set; }
    }
}
