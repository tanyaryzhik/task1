using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseJune14
{
    public class CarCollection<T> : MyList<T> where T : ICar, new()
    {
        public T this[string indexName]
        {
            get
            {
                T result = default(T);
                if (String.IsNullOrEmpty(indexName))
                {
                    throw new ArgumentException();
                }
                else
                {
                    for (int i = 0; i < this.Array.Length; i++)
                    {
                        if (this.Array[i].Name.Equals(indexName))
                            result = this.Array[i];
                    }
                }
                return result;
            }
        }

        public void Add(string name, int year)
        {
            T car = new T();
            car.Name = name;
            car.Year = year;
            base.Add(car);
        }
    }
}
