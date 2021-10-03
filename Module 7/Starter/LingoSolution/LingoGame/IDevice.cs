using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingoGame
{
    public interface IDevice
    {
        void DrawDefault(char c);
        void DrawPartial(char c);
        void DrawExact(char c);
    }
}
