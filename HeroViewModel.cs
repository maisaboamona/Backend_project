namespace HomePage.Models.Home
{
    public class HeroViewModel
    {
        public string Title { get; set; }
        public string subTitle { get; set; }

    }
    public class HeroView
    {
        public IEnumerable<HeroView> Items { get; set; }
    }
}
