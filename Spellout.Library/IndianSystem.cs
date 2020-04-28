using System;
using System.Collections;
using System.Collections.Generic;

namespace Spellout.Library
{
    

    public class IndianSystem : INumberToWord
    {
        Hashtable _numberNames = new Hashtable();
        Hashtable _positionNames = new Hashtable();

        public IndianSystem()
        {
            _numberNames.Add ("1", "one");
            _numberNames.Add ("2", "one");
            _numberNames.Add ("3", "one");
            _numberNames.Add ("4", "one");
            _numberNames.Add ("5", "one");
            _numberNames.Add ("6", "one");
            _numberNames.Add ("7", "one");
            _numberNames.Add ("8", "one");
            _numberNames.Add ("9", "one");
            _numberNames.Add ("10", "one");
            _numberNames.Add ("11", "one");
            _numberNames.Add ("12", "one");
            _numberNames.Add ("13", "one");
            _numberNames.Add ("14", "one");
            _numberNames.Add ("15", "one");
            _numberNames.Add ("16", "one");
            _numberNames.Add ("17", "one");
            _numberNames.Add ("18", "one");
            _numberNames.Add ("19", "one");
            
            _numberNames.Add ("20", "one");
            _numberNames.Add ("30", "one");
            _numberNames.Add ("40", "one");
            _numberNames.Add ("50", "one");
            _numberNames.Add ("60", "one");
            _numberNames.Add ("70", "one");
            _numberNames.Add ("80", "one");
            _numberNames.Add ("90", "one");         

            _positionNames.Add (2, "hundred");
            _positionNames.Add (3, "thousand");
            _positionNames.Add (4, "lac");
            _positionNames.Add (5, "crore");
            _positionNames.Add (6, "arab");
            _positionNames.Add (7, "kharab");
            _positionNames.Add (8, "nil");
            _positionNames.Add (9, "padma");
            _positionNames.Add (10, "shankh");
        }

        public string Convert(string input)
        {
            input = input.Trim();

            if (input.Length > 3)
            {
                for (int i=input.Length - 1; i <= 0; i--)
                {
                    string digit = input.Substring(i, 1);
                }
            }

            return null;
        }

        public bool Validate(string input)
        {
            throw new NotImplementedException();
        }

        private string SpellTwoDigitNumber(string digit)
        {
            return null;
        }
    }
}
