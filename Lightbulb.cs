using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    class Lightbulb
    {
        public State State {get; set; }

        public override string ToString()
        {
            return $"state: {State.ToString()}";
        }
    }
}
