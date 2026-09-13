using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimMethoOverloadOverrid
{
  class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal Makes Sound");
        }
    }

    class Peacock : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("The peacock screams");
        }
    }

}
