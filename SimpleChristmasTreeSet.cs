using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    class SimpleChristmasTreeSet : ChristmasTreeSet<Lightbulb>
    {
        public SimpleChristmasTreeSet(int counteSimpleLighbulbs): base(counteSimpleLighbulbs)
        {
        }

        public override List<Lightbulb> Build(int lightbulbsCount) 
        {
            List<Lightbulb> Lightbulbs = new List<Lightbulb>();
            for (int i = 0; i < lightbulbsCount; i++)
            {
                Lightbulbs.Add(new Lightbulb());
            }
            return Lightbulbs;
        }
    }
}
