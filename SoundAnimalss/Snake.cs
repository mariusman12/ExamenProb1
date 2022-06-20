using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundAnimalss
{
    internal class Snake : Animal
    {
        public override string Name
        {
            get { return "snake"; }
        }

        public override string MakeSound()
        {
            return "ssssssss";
        }
    }
}
