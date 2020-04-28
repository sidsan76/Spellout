using System;

namespace Spellout.Library
{
    public interface INumberToWord
    {
        public string Convert(string input);
        public bool Validate(string input);
    }
}
