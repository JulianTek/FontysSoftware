using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    //Ctor already checks whether or not a container is empty and will change its parameter, therefore there's no need to check in the generator method
    public class Container
    {
        public Container(bool isEmpty, bool contentNeedsCooling, bool valuableContent, int weight)
        {
            IsEmpty = isEmpty;
            if (IsEmpty)
            {
                ValuableContent = false;
                ContentNeedsCooling = false;
                Weight = 4;
            }
            else
            {
                ValuableContent = valuableContent;
                ContentNeedsCooling = contentNeedsCooling;
            }
            Weight = weight;
        }

        // Weight always in tonnes
        public bool ValuableContent { get; private set; }
        public bool ContentNeedsCooling { get; private set; }
        public bool IsEmpty { get; private set; }
        public int Weight { get; set; }
    }
}
