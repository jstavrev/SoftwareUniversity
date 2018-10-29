using Dogs.Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dogs.Models
{
    public class DogsViewModel
    {
        public DogsViewModel()
        {

        }

        public DogsViewModel(Dog dog)
        {
            this.Id = dog.Id;
            this.Name = dog.Name;
            this.Age = dog.Age;
            this.Breed = dog.Breed;
            this.ImageURL = dog.ImageURL;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Breed { get; set; }

        public string ImageURL { get; set; }
    }
}
