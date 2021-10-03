using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLingo
{
    static class LingoExtension
    {  
        public static bool IsGuessed(this LingoWord guess)
        {
            bool[] isExact = new bool[guess.Count];
            for (int i = 0; i < guess.Count; i++)
            {
                if (guess[i] is ExactCharacter)
                {
                    isExact[i] = true;
                }
            }
            return !isExact.Contains(false);
        }       
        public static bool IsExact(this LingoCharacter character)
        {
            return character is ExactCharacter;
        }
    }
}
