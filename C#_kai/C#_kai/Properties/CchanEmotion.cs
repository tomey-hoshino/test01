using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__kai.Properties
{
    class CchanEmotion
    {
        private Cdictionary _dictionary;

        private int _mood;

        private const int MODE_MIN = -15;
        private const int MODE_MAX = 15;

        private const int MOOD_RECONVERY = 1;

        public int Mood
        { get => _mood; }

        public CchanEmotion(Cdictionary dictionary)
        {
            _dictionary = dictionary;
            _mood = 0;
        }

        public void Update(string input)
        {
            if (_mood < 0)
                _mood += MOOD_RECONVERY;
            else if (_mood > 0)
                _mood -= MOOD_RECONVERY;

            foreach (ParseItem item in _dictionary.Pattern)
            {
                if (!string.IsNullOrEmpty(item.Match(input)))
                {
                    Adjust_mood(item.Modify);
                }
            }
        }

        private void Adjust_mood(int val)
        { 
            _mood += val;
            if (_mood < MODE_MIN)
                _mood = MODE_MIN;
            else if (_mood > MODE_MAX)
                _mood = MODE_MAX;
        }
    }
}

