namespace HomePage.Models.Home
{
    public class HomeViewModel

    {

        public IEnumerable<AboutViewModel> AboutItemViewModel { get; set; }
        public IEnumerable<servicess> servicesItem { get; set; }


        public IEnumerable<HeroViewModel> HeroView { get; set; }
        public IEnumerable<DoctorsViewModel> DoctorsItemViewModel { get; set; }

        public IEnumerable<ArticlesViewModel> ArticleItemViewModel { get; set; }
    }
}
