using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingoGame
{
    public class LingoCharacter
    {
        private char character;
        private int position;

        public char Character
        {
            get
            {
                return character;
            }
            set
            {
                character = char.ToLower(value);
            }
        }
        public int Position
        {
            get
            {
                return position;
            }
            set
            {
                if (value >= 0)
                {
                    position = value;
                }
            }
        }
        public static bool ExactlyEqual(LingoCharacter a, LingoCharacter b)
        {
            return a.Character == b.Character && a.Position == b.Position;
        }
        public static bool PartialEqual(LingoCharacter a, LingoCharacter b)
        {
            return a.Character == b.Character && a.Position != b.Position;
        }
        public virtual void Draw(IDevice device)
        {
            device.DrawDefault(Character);
            
        }
        // TODO 1: Change this method into generic method that returns an object
        // of the given generic type. Make sure that the generic type can only be
        // of type LingoCharacter
        public static LingoCharacter Create(char c, int i)
        {
            return new LingoCharacter { Character = c, Position = i };
        }
    }
}
