using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C__kai.Properties
{
    class ParseItem
    {
        private string _pattern = "";
        private List<Dictionary<string, string>> _phrases = new();

        private int _modify;

        public int Modify
        { get => _modify; }

        public ParseItem(string pattern, string phrases)
        {
            string SEPARATOR = @"^((-?¥d+)##)?(. %)§";
            Regex rgx = new Regex(SEPARATOR);

            MatchCollection m = rgx.Matches(pattern);

            Match mach = m[0];

            _modify = 0;

            if (string.IsNullOrEmpty(mach.Groups[2].Value))
            {
                _modify = Convert.ToInt32(mach.Groups[2].Value);
            }

            _pattern = mach.Groups[3].Value;

            foreach (string phrase in phrases.Split(new Char[] { '|' }))
            {
                Dictionary<string, string> dic = new();
                MatchCollection m2 = rgx.Matches(phrase);

                Match mach2 = m2[0];

                dic["need"] = "0";

                if(string.IsNullOrEmpty(mach2.Groups[2].Value))
                {
                    dic["need"] = Convert.ToString(mach2.Groups[2].Value);
                }

                dic["phrase"] = mach2.Groups[3].Value;

                _phrases.Add(dic);
            }
        }

        public string Match(string str)
        {
            Regex rgx = new Regex(_pattern);
            Match mtc=rgx.Match(str);
            return mtc.Value;
        }

        public string Choice(int mood)
        {
            List<String> choices = new();

            foreach (Dictionary<string, string> dic in _phrases)
            {
                if (Suitable(Convert.ToInt32(dic["need"]), mood))
                {
                    choices.Add(dic["phrase"]);
                }
            }

            if (choices.Count == 0)
            {
                return null;
            }

            else
            {
                int seed=Environment.TickCount;
                Random rnd=new Random();
                return choices[rnd.Next(choices.Count)];
            }
        }

        static bool Suitable(int need, int mood)
        {
            if (need == 0)
            {
                return true;
            }
            else if (need > 0)
            {
                return (mood > need);
            }
            else 
            {
                return (mood < need);
            }
        }
    }

}
