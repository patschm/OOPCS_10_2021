using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingoGame
{
    public class PartialCharacter : LingoCharacter
    {
        // TODO 2b: Modify the Draw method to accept an argument of type IDevice
        // In the function replace the existing code for the DrawPartial method.
        public override void Draw(IDevice device)
        {
            device.DrawPartial(Character);
           
        }
        public static new PartialCharacter Create(char c, int i)
        {
            return new PartialCharacter { Character = c, Position = i };
        }
    }
}
