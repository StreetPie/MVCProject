using MVCProject.Models;

namespace MVCproject.ViewModels
{
    public class IndexViewModel
    {
        public IndexViewModel(List<User> user )
        {
            this.user = user;
        }

        public List<User> user { get; set; }
     
    }
}
