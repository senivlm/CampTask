using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampTask2
{
    class Pair
    {
        private int number;
        private int frequency;

        public Pair(int number, int frequency)
        {
            this.Number = number;
            this.Frequency = frequency;
        }

        public int Number { get => number; set => number = value; }
        public int Frequency { get => frequency; set => frequency = value; }
        public override string ToString()
        {
            return $"{number} - {frequency}";
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(!(obj is Pair))
            {
                return false;
            }
            return (this.Number == ((Pair)obj).Number) && (this.Frequency == ((Pair)obj).Frequency);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
