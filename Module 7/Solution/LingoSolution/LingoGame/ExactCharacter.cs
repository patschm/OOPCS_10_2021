using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingoGame
{
    public class ExactCharacter : LingoCharacter
    {
        public override void Draw(IDevice device)
        {
            device.DrawExact(Character);
           
        }
        // TODO 2: Remove this method
       
    }
}
