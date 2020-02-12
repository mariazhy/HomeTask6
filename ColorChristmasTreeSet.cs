using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    class ColorChristmasTreeSet : ChristmasTreeSet<ColorLightbulb>
    {
        public ColorChristmasTreeSet(int countColorLighbulbs) : base(countColorLighbulbs)
        {

        }

        public override List<ColorLightbulb> Build(int lightbulbsCount)
        {
            List<ColorLightbulb> ColorLightbulbs = new List<ColorLightbulb>();
            for (int i = 0; i < lightbulbsCount; i++)
            {
                var lightbulb = new ColorLightbulb(DefineColor(i + 1));
                ColorLightbulbs.Add(lightbulb);
            }
            return ColorLightbulbs;
        }

        public Color DefineColor(int index)
        {
            var a = index % 4;
            switch (a)
            {
                case 1: return Color.Red;
                case 2: return Color.Yellow;
                case 3: return Color.Blue;
                case 0: return Color.Green;
                default: return Color.White;
            }
        }
    }
}
