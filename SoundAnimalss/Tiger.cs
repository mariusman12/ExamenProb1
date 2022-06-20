using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundAnimalss
{
    internal class Tiger : Animal
    {
        public override string Name
        {
            get { return "tiger"; }
        }


        public override string MakeSound()
        {
            return "roarrr";
        }
    }
}
