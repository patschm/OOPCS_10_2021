using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingoGame
{
    public class PartialCharacter : LingoCharacter
    {
        public override void Draw(IDevice device)
        {
            device.DrawPartial(Character);
           
        }
        // TODO 3: Remove this method and fix all errors
        public static PartialCharacter Create(char c, int i)
        {
            return new PartialCharacter { Character = c, Position = i };
        }
    }
}
