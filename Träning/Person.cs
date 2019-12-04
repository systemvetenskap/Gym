using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Träning
{
    class Person
    {
        public int  Height { get; set; }
        public int Mass { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }

        public virtual double Bmi()
        {
            return 24.3;
        }
    }

    class GymOnly : Person
    {
        public int PersonbestBench { get; private set; }

        public GymOnly(int pb)
        {
            PersonbestBench = pb;
        }
    }

    class TotalMember : Person
    {
    }

    class EliteMember : Person
    {

        public override double Bmi()
        {
            return base.Bmi() - 2;
        }
    }
}
