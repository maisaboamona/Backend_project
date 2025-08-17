namespace HomePage.Models.Home
{
    public class servicess
    {
        public string Title { get; set; }

        public string subTitle { get; set; }

        public string icon { get; set; } 
        public bool IsActive { get; set; }


    }

    public class servicesItem
    {
        public IEnumerable<servicess> Items { get; set; }
    }
}
 



