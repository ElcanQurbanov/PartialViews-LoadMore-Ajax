using FrontToBack.Models;

namespace FrontToBack.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public SliderBackground SliderBackground { get; set; }
        public IEnumerable<RecentWork> RecentWorks { get; set; }
        public IEnumerable<Service> Services { get; set; }
    }
}
