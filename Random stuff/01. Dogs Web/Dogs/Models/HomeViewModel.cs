using Dogs.Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dogs.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(IEnumerable<Dog> dogs)
        {
            this.Dogs = dogs.Select(d => new DogsViewModel(d)).ToList();
        }

        public string Header = "Who let the dogs out?";

        public IEnumerable<DogsViewModel> Dogs { get; set; }
    }
}
