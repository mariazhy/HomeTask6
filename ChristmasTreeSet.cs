using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    abstract class ChristmasTreeSet<TLightbulb>
        where TLightbulb : Lightbulb
    {
        private int _currentMinute;
        private List<TLightbulb> _lightbulbs = new List<TLightbulb>();
        public ChristmasTreeSet(int countLightBulbs)
        {
            _lightbulbs = Build(countLightBulbs);
        }

        public abstract List<TLightbulb> Build(int lightbulbsCount);

        public void SetLightulbState()
        {
            _currentMinute = DateTime.Now.Minute;
            bool isEvenMinute = _currentMinute % 2 == 0;
            for (int i = 0; i < _lightbulbs.Count;  i++)
            {
                if ((i % 2 == 0 && isEvenMinute) || (i % 2 == 1 && !isEvenMinute))
                {
                    _lightbulbs[i].State = State.On;
                }
                else 
                {
                    _lightbulbs[i].State = State.Off;
                }
            }
        }

        public void PrintChristmatTreeSetState()
        {
            SetLightulbState();
            int i = 0;
            Console.WriteLine($"Current Minute: {_currentMinute}");
            foreach (var lightbulb in _lightbulbs)
            {
                Console.WriteLine($"{i}: {lightbulb.ToString()}");
                i++;
            }
        }
    }
}