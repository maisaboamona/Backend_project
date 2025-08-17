namespace HomePage.Models.Home
{
    public class DoctorsViewModel
    {
        public string Title { get; set; }

        public string subTitle { get; set; }
        public string UrlImag { get; set; }

        public bool IsActive { get; set; }
    }
    public class DoctorsItemViewModel
    {
        public IEnumerable<DoctorsItemViewModel> Items { get; set; }
    }
}
