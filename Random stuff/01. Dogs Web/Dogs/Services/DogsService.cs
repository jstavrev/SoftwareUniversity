using Dogs.Data;
using Dogs.Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dogs.Services
{
    public class DogsService
    {
        private DogsWebContext context;

        public DogsService(DogsWebContext context)
        {
            this.context = context;
        }

        public IEnumerable<Dog> GetAllDogs()
        {
            return this.context.Dogs.ToList();
        }

        public Dog AddDog(Dog dog)
        {
            this.context.Dogs.Add(dog);
            this.context.SaveChangesAsync();

            return dog;
        }

        public Dog GetDog(int id)
        {
            return this.context.Dogs.Find(id);
        }
    }
}
