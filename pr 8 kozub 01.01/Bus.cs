using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_8_kozub_01._01
{
    internal class Bus : ICar, ITransport, IComparable
    {
        private int _capacity;
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (value > 0)
                {
                    _capacity = value;
                }
                else throw new ArgumentOutOfRangeException();
            }
        }

        public int CompareTo(object? obj)
        {
            Bus temp = (Bus)obj;
            if (this.Capacity > temp.Capacity) return 1;
            if(this.Capacity < temp.Capacity) return -1;
            return 0;
        }

        public Bus()
        {
            Brand = String.Empty;
            Model = String.Empty;
            Capacity = 1;
        }

        public Bus(string brand, string model, int capacity)
        {
            Brand = brand;
            Model = model;
            Capacity = capacity;
        }

        public string BusInformation(Bus bus)
        {
            return ($"Автобус марки {bus.Brand} модели {bus.Model} с вместимостью {bus.Capacity} человек стоит на вокзале");
        }
    }
}
