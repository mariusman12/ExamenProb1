using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundAnimalss
{
    internal class Dog : Animal
    {
        public override string Name
        {
            get { return "dog"; }
        }

        public override string MakeSound()
        {
            return "ham";
        }
    }
}
