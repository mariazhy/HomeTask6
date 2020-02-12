using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    class ColorLightbulb : Lightbulb
    {
        public ColorLightbulb(Color color)
        {
            Color = color;
        }

        public ColorLightbulb()
        {
        }

        public Color Color { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}, color: {Color.ToString()}"; 
        }
    }
}
