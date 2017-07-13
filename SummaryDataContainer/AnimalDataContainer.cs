using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaryDataContainer
{
    class AnimalDataContainer: DataContainer
    {
        private Dog _Dog = null;

        public AnimalDataContainer(Dog dog)
        {
            _Dog = dog ?? throw new ArgumentNullException(nameof(dog));
        }

        public static implicit operator Dog(AnimalDataContainer dt)
        {
            return dt._Dog;
        }
    }
}
