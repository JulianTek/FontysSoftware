using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    class Container
    {
        public Container(int weight, bool isEmpty)
        {
            IsEmpty = isEmpty;
            if (IsEmpty)
            {
                ValuableContent = false;
                ContentNeedsCooling = false;
            }
            else
            {
                ValuableContent = true;
                ContentNeedsCooling = true;
            }

            Weight = weight;
        }

        public bool ValuableContent { get; private set; }
        public bool ContentNeedsCooling { get; private set; }
        public bool IsEmpty { get; private set; }
        public int Weight { get; private set; }
        public int WeightOnTop { get; private set; }
    }
}
