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
            _numberNames.Add ("2", "two");
            _numberNames.Add ("3", "three");
            _numberNames.Add ("4", "four");
            _numberNames.Add ("5", "five");
            _numberNames.Add ("6", "six");
            _numberNames.Add ("7", "seven");
            _numberNames.Add ("8", "eight");
            _numberNames.Add ("9", "nine");
            _numberNames.Add ("10", "ten");
            _numberNames.Add ("11", "eleven");
            _numberNames.Add ("12", "twelve");
            _numberNames.Add ("13", "thirteen");
            _numberNames.Add ("14", "fourteen");
            _numberNames.Add ("15", "fifteen");
            _numberNames.Add ("16", "sixteen");
            _numberNames.Add ("17", "seventeen");
            _numberNames.Add ("18", "eighteen");
            _numberNames.Add ("19", "ninteen");
            
            _numberNames.Add ("20", "twenty");
            _numberNames.Add ("30", "thirty");
            _numberNames.Add ("40", "fourty");
            _numberNames.Add ("50", "fifty");
            _numberNames.Add ("60", "sixty");
            _numberNames.Add ("70", "seventy");
            _numberNames.Add ("80", "eighty");
            _numberNames.Add ("90", "ninty");         

            _positionNames.Add (2, "hundred");
            _positionNames.Add (3, "thousand");
            _positionNames.Add (4, "thousand");
            _positionNames.Add (5, "lac");
            _positionNames.Add (6, "lac");
            _positionNames.Add (7, "crore");
            _positionNames.Add (8, "crore");
            _positionNames.Add (9, "arab");
            _positionNames.Add (10, "arab");
            _positionNames.Add (11, "kharab");
            _positionNames.Add (12, "kharab");
            _positionNames.Add (13, "nil");
            _positionNames.Add (14, "nil");
            _positionNames.Add (15, "padma");
            _positionNames.Add (16, "padma");
            _positionNames.Add (17, "shankh");
            _positionNames.Add (18, "shankh");
        }

        public string Convert(string input)
        {
            input = input.Trim();
            if (input == "0")
            {
                return "zero";
            }

            string spellNumber = string.Empty;

            if (input.Length > 3)
            {
                spellNumber = SpellThreeDigitNumber(input.Substring(input.Length - 3, 3));
                for (int i=input.Length - 3; i > 0; i = i-2)
                {
                    if (i < 1)
                    {
                        break;
                    }

                    string twoDigitNum = string.Empty;
                    if (i == 1)
                    {
                        twoDigitNum = SpellTwoDigitNumber(input.Substring(0, 1));
                    }
                    else
                    {
                        twoDigitNum = SpellTwoDigitNumber(input.Substring(i -2, 2));
                    }

                    if (!string.IsNullOrEmpty(twoDigitNum.Trim()))
                    {
                        spellNumber = twoDigitNum
                            + " " 
                            + (string) _positionNames[input.Length - i] 
                            + " " + spellNumber;                            
                    }

                }
            }
            else if (input.Length == 3)
            {
                spellNumber = SpellThreeDigitNumber(input);
            }
            else
            {
                spellNumber = SpellTwoDigitNumber(input);
            }

            return spellNumber.Trim();
        }

        public bool Validate(string input)
        {
            throw new NotImplementedException();
        }

        private string SpellTwoDigitNumber(string digit)
        {
            if (digit == "0" || digit == "00")
                return string.Empty;

            if (_numberNames.ContainsKey(digit))
            {
                return (string)_numberNames[digit];
            }
            else
            {
                return ((string)_numberNames[digit.Substring(0, 1) + "0"] 
                        + " "
                        + (digit.Length > 1 ? (string)_numberNames[digit.Substring(1, 1)] : string.Empty)).Trim();
            }
            
        }

        
        private string SpellThreeDigitNumber(string digit)
        {
            string twoDigitNumber = SpellTwoDigitNumber(digit.Substring(1, 2));
            return ( (digit.Substring(0, 1) =="0" ? string.Empty : 
                        (string)_numberNames[digit.Substring(0, 1)] + " " + (string) _positionNames[2]) 
                                + " " + twoDigitNumber);
        }
    }
}
